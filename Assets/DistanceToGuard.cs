using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DistanceToGuard : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject securityGuard;

    [SerializeField]
    private Volume m_Volume;

    private Vignette vignette;

    private float maxDist = 13;
    private float minDist = 3;
    // Start is called before the first frame update
    void Start()
    {
        m_Volume.profile.TryGet(out vignette);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerLoc = new Vector2(player.transform.position.x, player.transform.position.y);
        Vector2 guardLoc = new Vector2(securityGuard.transform.position.x, securityGuard.transform.position.y);
        float dist = Vector2.Distance(playerLoc, guardLoc);
        float lerp = dist / maxDist;
        if(lerp > 1)
        {
            lerp = 1;
        }
        float vIntensity = 1 - lerp;
        vignette.intensity.Override(vIntensity);
    }
}
