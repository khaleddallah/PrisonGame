using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private GameObject ShootPoint;
    [SerializeField] private GameObject Crosshair;

    RaycastHit2D hit;
    Vector3 dir0;
    // Start is called before the first frame update
    void Start()
    {
        dir0 = new Vector3(0f,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            StartCoroutine(Shoot());
        }
    }

    private IEnumerator Shoot(){
        dir0 = Crosshair.transform.position - ShootPoint.transform.position ;
        hit = Physics2D.Raycast(ShootPoint.transform.position, dir0.normalized);
        
        lineRenderer.SetPosition(0, ShootPoint.transform.position);
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.3f;

        if (hit){
            Debug.Log(hit.transform.name);
            lineRenderer.SetPosition(1, hit.point);
        }
        else{
            lineRenderer.SetPosition(1, ShootPoint.transform.position+dir0.normalized*100f);
        }
        lineRenderer.enabled = true;
        yield return new WaitForSeconds(0.02f);
        lineRenderer.enabled = false;

    }
}
