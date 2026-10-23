using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public delegate void HumanoidHitDelegate();
    public static event HumanoidHitDelegate OnHitType1;
    public static event HumanoidHitDelegate OnHitType2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Type1")
        {
            if (OnHitType1 != null) OnHitType1();
        }
        else if (collision.gameObject.tag == "Type2")
        {
            if (OnHitType2 != null) OnHitType2();
        }
    }
}
