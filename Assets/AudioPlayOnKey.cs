using UnityEngine;

public class AudioPlayOnKey : MonoBehaviour
{
    public AudioClip[] teacherClips = new AudioClip[4];
    public AudioClip[] studentClips = new AudioClip[4];

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    void Update()
    {
        // Teacher: Keys 1–4
        if (Input.GetKeyDown(KeyCode.Alpha1)) PlayClip(teacherClips, 0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) PlayClip(teacherClips, 1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) PlayClip(teacherClips, 2);
        if (Input.GetKeyDown(KeyCode.Alpha4)) PlayClip(teacherClips, 3);

        // Student: Keys 5–8
        if (Input.GetKeyDown(KeyCode.Alpha5)) PlayClip(studentClips, 0);
        if (Input.GetKeyDown(KeyCode.Alpha6)) PlayClip(studentClips, 1);
        if (Input.GetKeyDown(KeyCode.Alpha7)) PlayClip(studentClips, 2);
        if (Input.GetKeyDown(KeyCode.Alpha8)) PlayClip(studentClips, 3);
    }

    void PlayClip(AudioClip[] clips, int index)
    {
        if (index >= 0 && index < clips.Length && clips[index] != null)
        {
            audioSource.Stop();
            audioSource.clip = clips[index];
            audioSource.Play();
        }
    }
}
