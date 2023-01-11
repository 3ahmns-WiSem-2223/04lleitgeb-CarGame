using UnityEngine;
using UnityEngine.UI;

public class DestroyOnCollisionScript : MonoBehaviour
{
    public int value = 1;
    public Text pickUpText;
    public Text totalText;
    private int pickUpCount = 0;
    private int totalCount = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (pickUpCount == 0 && collision.gameObject.tag == "PickUp")
        {
            Destroy(collision.gameObject);
            pickUpCount += value;

            Update();
        }

        else if (collision.gameObject.tag == "DropOutStation" && pickUpCount > 0)
        {
            pickUpCount -= value;
            totalCount += value;

            Update();
        }

        if (totalCount == 5)
        {
            Time.timeScale = 0;
        }

    }

    void Update()
    {
        pickUpText.text = "Collected Keys: " + pickUpCount;
        totalText.text = "Total Keys: " + totalCount + "/5";
    }

}