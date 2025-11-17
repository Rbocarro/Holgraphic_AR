using UnityEngine;
using PrimeTween;
public class CardManager : MonoBehaviour
{
    bool hasPlayed = false;

    void OnEnable()
    {
        // Play only the first time the target becomes tracked
       // if (!hasPlayed)
        {
            hasPlayed = true;
            PlaySpawnAnimation();
        }
    }

    void PlaySpawnAnimation()
    {
        transform.localScale = new Vector3(1f, 1f, 0f);

        // Animate to (1, 1, 1) with Bounce ease
        Tween.Scale(transform, Vector3.one, 0.3f, Ease.InBounce);
    }
}
