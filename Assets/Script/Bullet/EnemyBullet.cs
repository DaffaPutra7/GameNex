using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 7f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);

        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameOverManager gm = FindFirstObjectByType<GameOverManager>();
            if (gm != null) gm.TriggerGameOver();

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}