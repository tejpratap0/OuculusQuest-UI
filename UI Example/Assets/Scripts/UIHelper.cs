using UnityEngine;

public class UIHelper : MonoBehaviour
{
    [SerializeField] LaserPointer.LaserBeamBehavior LazerBehaviour;
    [SerializeField] LaserPointer LazerObjects;

    void Start()
    {
        LazerObjects.laserBeamBehavior = LazerBehaviour;
    }
     
}
