using UnityEngine;
namespace Interface
{
    public class InterfaceNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            HdCar goodcar = new HdCar(new Good());
            goodcar.Run();

            HdCar badcar = new HdCar(new Bad());
            badcar.Run();


        }
    }
}