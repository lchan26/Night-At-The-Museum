using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionBone : MonoBehaviour
{
    private Vector3 targetPos;
    private Vector3 startPos;
    private float targetAngle = 90;
    private float startAngle = -90;
    private float t = 0;
    [SerializeField]
    private float rotationDuration;
    [SerializeField]
    private float translationDuration;
    private ParticleSystem pSystem;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(targetPos != null)
        {
            if(t <= rotationDuration)
            {
                float x = t / rotationDuration;
                float y = 2 * x - x * x;
                float zAngle = Mathf.LerpAngle(startAngle, targetAngle, y);
                Quaternion localRotation = Quaternion.AngleAxis(zAngle, Vector3.forward);
                gameObject.GetComponent<RectTransform>().SetLocalPositionAndRotation(startPos, localRotation);
            }
            else if(t > rotationDuration && t <= translationDuration + rotationDuration)
            {
                float x = (t - rotationDuration) / translationDuration;
                float y = x * x;
                gameObject.GetComponent<RectTransform>().SetLocalPositionAndRotation(Vector3.Lerp(startPos, targetPos, y), gameObject.GetComponent<RectTransform>().localRotation);
            }
            else
            {
                pSystem.Play();
                Destroy(this.gameObject);
            }
            t += Time.deltaTime;
        }
    }

    public void SetTargetPos(Vector3 targetPosition)
    {
        targetPos = targetPosition;
        startPos = gameObject.GetComponent<RectTransform>().localPosition;
    }

    public void SetParticleSystem(ParticleSystem pSys)
    {
        pSystem = pSys;
    }
}
