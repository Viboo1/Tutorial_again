using Unity.Mathematics.Geometry;
using UnityEngine;

public class FrameCounter : MonoBehaviour
{
    public float number1 = 7;
    public float number2 = 14;

   
    // Start is called before the first frame update
    void Start()
    {
        // Store all operations in a string array with their corresponding lambda expressions
        string[] operations = new string[]
        {
            $"Addition: {number1 + number2}",
            $"Subtraction: {number1 - number2}",
            $"Multiplication: {number1 * number2}",
            $"Division: {number1 / number2}",
            $"Exponentiation: {Mathf.Pow(number1, number2)}", // Using Mathf.Pow for power operations (if intended)
            $"Modulo: {number1 % number2}"
        };

        // Loop through and log all results
        foreach (var operation in operations)
        {
            Debug.Log(operation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}