
using UnityEngine;

namespace ___WORKDATA___.scripts
{
    public class ExampleScript : MonoBehaviour
    {
        private bool firstBool; //true or false
        private int firstInteger;
        private int addedInteger; //whole numbers
        private string firstString; //text

        void Start()
        {
            Debug.Log("Das Unityprogramm wurde gestartet.");

            firstBool = false;
            firstInteger = 8;
            firstString = "sample text";

            Debug.Log("Mein Bool: " + firstBool);
            Debug.Log("Mein Integer: " + firstInteger);
            Debug.Log("Mein String: " + firstString);

            addedInteger = firstInteger + 2;

            Debug.Log("New Integer: " + addedInteger);


        }
    }
}

    

