using UnityEngine;
using System.Collections.Generic;

public class HT_HatController : MonoBehaviour
{

    public Camera cam;

    private float maxWidth;
    private bool canControl;
    private float projectileVelocity;
    public GameObject tirinhoPrefab;
    private List<GameObject> Projetils = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
        projectileVelocity = 10;
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        float hatWidth = GetComponent<Renderer>().bounds.extents.x;
        maxWidth = targetWidth.x - (hatWidth / 4);
        canControl = false;
    }

    // Update is called once per physics timestep
    void FixedUpdate()
    {
        if (canControl)
        {
            Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 targetPosition = new Vector3(rawPosition.x, 0.0f, 0.0f);
            float targetWidth = Mathf.Clamp(targetPosition.x, -maxWidth, maxWidth);
            targetPosition = new Vector3(targetWidth, targetPosition.y, targetPosition.z);
            GetComponent<Rigidbody2D>().MovePosition(targetPosition);
        }
        if (Input.GetButtonDown("Jump"))
        {
            GameObject tiro = (GameObject)Instantiate(tirinhoPrefab, transform.position, Quaternion.identity);
            Projetils.Add(tiro);
        }
        for (int i = 0; i < Projetils.Count; i++)
        {
            GameObject goBullet = Projetils[i];
            if (goBullet !=null)
            {
                goBullet.transform.Translate(new Vector3(0, 1)*Time.deltaTime*projectileVelocity);
                Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint(goBullet.transform.position);
                if (bulletScreenPos.y >= Screen.height)
                {
                    DestroyObject(goBullet);
                    Projetils.Remove(goBullet);
                }
            }
        }
    }

    public void ToggleControl(bool toggle)
    {
        canControl = toggle;
    }
}
