using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private Transform[] pov;

    private int currentPov, nextPov;
    
    void Start()
    {
        Screen.SetResolution(1080, 1920, true);
        currentPov = 0;
        nextPov = 0;
    }

    public void MoveRight()
    {
        if (currentPov == 0) nextPov = pov.Length - 1;
        else nextPov--;       

        currentPov = nextPov;
    }

    public void MoveLeft()
    {
        if (currentPov == pov.Length - 1) nextPov = 0;
        else nextPov++;
        
        currentPov = nextPov;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, pov[nextPov].position, 0.1f);
        transform.rotation = Quaternion.Lerp(transform.rotation, pov[nextPov].rotation, 0.1f);
    }
}