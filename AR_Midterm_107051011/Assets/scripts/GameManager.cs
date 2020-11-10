using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("藍藍")]
    public Transform blue;
    [Header("紫紫")]
    public Transform purple;
    [Header("虛擬搖桿")]
    public FloatingJoystick Joystick;
    [Header("旋轉速度"), Range(0f, 10f)]
    public float Speed = 1.5f;
    [Header("縮放"), Range(0.1f, 1f)]
    public float Size = 0f;
    [Header("藍藍動畫元件")]
    public Animator aniblue;
    [Header("紫紫動畫元件")]
    public Animator anipurple;

    private void Start()
    {
        print("遊戲開始事件");
    }
    private void Update()
    {
        print("遊戲更新事件");
        print(Joystick.Vertical);
        blue.Rotate(0, Joystick.Horizontal * Speed, 0);
        purple.Rotate(0, Joystick.Horizontal * Speed, 0);
        blue.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * Size;
        blue.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(blue.localScale.x, 0.5f, 2f);
        purple.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * Size;
        purple.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(purple.localScale.x, 0.5f, 2f);

    }
    public void PlayAnimation(string aniname)
    {
        print(aniname);
        aniblue.SetTrigger(aniname);
        anipurple.SetTrigger(aniname);
    }
}
