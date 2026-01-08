using UnityEngine;

public class FloatUI : MonoBehaviour
{
    public float floatSpeed = 2f;
    public float floatHeight = 20f;

    private Vector2 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.localPosition = new Vector2(startPos.x, newY);
    }
}
