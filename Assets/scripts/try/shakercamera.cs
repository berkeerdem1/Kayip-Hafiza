using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakercamera : MonoBehaviour
{
    private float shaketimeRemaining, shakePower, shakefadeTime, shakeRotation;
    public static shakercamera Instance;
    public float rotatitonmultipler;

    void Start()
    {
        Instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("shake çalıştı");
            startshake(.5f, 1f);
        }
    }
    private void lateupdate()
    {
        if (shaketimeRemaining > 0)
        {
            shaketimeRemaining -= Time.deltaTime;

            float xAmonut = Random.Range(-1f, 1f) * shakePower;
            float Yamount = Random.Range(-1f, 1f) * shakePower;

            transform.position += new Vector3(xAmonut, Yamount, 0f);

            shakePower = Mathf.MoveTowards(shakePower, 0f, shakefadeTime * Time.deltaTime);

            shakeRotation = Mathf.MoveTowards(shakeRotation, 0f, shakefadeTime * rotatitonmultipler * Time.deltaTime);
        }
        transform.rotation = Quaternion.Euler(0f, 0f, shakeRotation * Random.Range(-1f, 1f));
    }
    public void startshake(float length, float power)
    {
        shaketimeRemaining = length;
        shakePower = power;

        shakefadeTime = power / length;

        shakeRotation = power * rotatitonmultipler;
    }

}
