using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile"))
        {
            // Sumar puntuación
            FindObjectOfType<ScoreManager>().AddPoint();

            // Destruir target
            Destroy(gameObject);
        }
    }
}
