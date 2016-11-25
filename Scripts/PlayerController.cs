using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float carSpeed = 5.0f;

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * carSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(z, 0, 0);
    }
    void OnTriggerEnter(Collider Clock)
    {
        if (Clock.gameObject.CompareTag("Clock"))
        {
            Clock.gameObject.SetActive(false);
            Clock.gameObject.GetComponent<myTimer>();
        }
    }

}