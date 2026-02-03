using UnityEngine;

public class playerMov : MonoBehaviour
{
    [SerializeField]
    public float movSpeed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     float horInput = Input.GetAxis("Horizontal");
     float vertInput = Input.GetAxis("Vertical");

     Vector3 direction = new Vector3(horInput, vertInput, 0);

     transform.Translate(direction * movSpeed * Time.deltaTime);
    }
}
