using UnityEngine;

public class ShooterEnemy : MonoBehaviour
{
    public float speed = 2f;
    public GameObject enemyBulletPrefab;
    public float shootInterval = 3f;

    private float topScreenY;

    void Start()
    {
        InvokeRepeating("Shoot", 1f, shootInterval);

        Camera cam = Camera.main;
        topScreenY = cam.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < -6f) Destroy(gameObject);
    }

    void Shoot()
    {
        if (transform.position.y > topScreenY) return;

        if (enemyBulletPrefab != null)
        {
            Instantiate(enemyBulletPrefab, transform.position, enemyBulletPrefab.transform.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (transform.position.y > topScreenY) return;

        if (other.CompareTag("Peluru"))
        {
            ScoreManager sm = FindFirstObjectByType<ScoreManager>();
            if (sm != null) sm.AddScore(20);

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            GameOverManager gm = FindFirstObjectByType<GameOverManager>();
            if (gm != null) gm.TriggerGameOver();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}