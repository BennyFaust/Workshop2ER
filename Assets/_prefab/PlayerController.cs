using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace ExpandedR
{
    public class PlayerController : MonoBehaviour
    {

        public Text countText;
        public Text winText;

        private int count;

        void Start()
        {
            count = 0;
            SetCountText();
        }


        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive(false);
                count = count + 1;
                SetCountText();
            }
        }

        void SetCountText()
        {
            countText.text = "Count: " + count.ToString();
            if (count >= 12)
            {
                winText.gameObject.SetActive(true);
            }
        }
    }
}
