using UnityEngine;
using UnityEngine.UIElements;

public class Shoot : MonoBehaviour
{
    public AudioSource audio;
    public GameObject shellPrefab;
    public GameObject shellSpawnPosition;
    public GameObject target;
    Animator animator;
    public GameObject parrent;
    float speed = 17f;
    bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = parrent.GetComponent<Animator>();
    }

    void CanShootAgain()
    {
        canShoot = true;
    }

    void Fire()
    {
        if (canShoot)
        {
            animator.gameObject.SetActive(false);
            animator.gameObject.SetActive(true);
            animator.Play("demo_combat_shoot", 0, 0f);
            animator.SetBool("IsShooting", true);
            animator.SetBool("IsIdle", false);
            animator.SetBool("IsRunning", false);

            GameObject shell = Instantiate(shellPrefab, shellSpawnPosition.transform.position, shellSpawnPosition.transform.rotation);
            this.transform.rotation = shellSpawnPosition.transform.rotation;
            shell.GetComponent<Rigidbody>().velocity = speed * this.transform.forward;
            audio.Play();
            canShoot = false;
            Invoke(nameof(CanShootAgain), 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown((int)MouseButton.LeftMouse))
        {
            Fire();
        }
    }
}
