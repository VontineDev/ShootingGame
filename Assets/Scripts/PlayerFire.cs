using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField]
    private GameObject missilePrefab;

    private float timePassed;

    public VariableJoystick joystickFire;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

#if UNITY_EDITOR
        joystickFire.gameObject.SetActive(false);

        // If you push Fire1 button, Excute PlayerFire Method
        if (Input.GetButton("Fire1") && timePassed > 0.2f)
        {
            Fire();
            timePassed = 0;
        }
#elif UNITY_ANDROID
        if (joystickFire.Horizontal != 0 && timePassed > 0.2f)
        {
            Fire();
            timePassed = 0;
        }
#endif
    }

    void Fire()
    {
        var missile = Instantiate(missilePrefab); //Instantitate missile
        missile.transform.position = this.transform.position + new Vector3(0, 0.9f, 0); //set missile position as player's head
        //missile.transform.SetParent(this.transform);  //set missile's parent player
    }
}
