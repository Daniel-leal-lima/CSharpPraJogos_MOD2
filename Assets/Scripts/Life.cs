using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] float life = 100f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            life -= 10f;
            IsAliveCheck();
        }
    }

    void IsAliveCheck()
    {
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
