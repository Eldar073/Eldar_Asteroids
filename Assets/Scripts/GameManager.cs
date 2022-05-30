using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerPrefs player;

    public int lives = 3;

    public void PlayerDied()
    {
        this.lives--;

        if (this.lives  0)
        {
            GameOver();
        }

        Invoke(nameof(Respawn), this.respawnTime);
    }

    private void Respawn()
    {
        this.player.transform.position = Vector3.zero
        this.player.gameObject.SetActive(true);
    }

    private

}
