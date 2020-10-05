using Photon.Pun;
using Photon.Voice.Unity;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerVoice : MonoBehaviour
{

    public GameObject audioIcon;

    private PhotonView photonView;
    private AudioSource audioSource;

    private float updateStep = 0.1f;
    private int sampleDataLength = 1024;
    private float currentUpdateTime = 0f;
    private float[] clipSampleData;

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        var parentRot = transform.rotation.eulerAngles;
        audioIcon.transform.rotation = Quaternion.Euler(new Vector3(0, parentRot.y, 0));
    }

    void UpdateAudioState()
    {
        audioSource.clip.GetData(clipSampleData, audioSource.timeSamples);
        float clipLoudness = 0;
        foreach (float sample in clipSampleData)
        {
            clipLoudness += Mathf.Abs(sample);
        }
        clipLoudness /= sampleDataLength;

        if (clipLoudness > 0.005 && !audioIcon.activeSelf)
        {
            audioIcon.SetActive(true);
        }
        else if (clipLoudness < 0.005 && audioIcon.activeSelf)
        {
            audioIcon.SetActive(false);
        }
    }

    IEnumerator TryGetAudioSpeaker()
    {
        while (audioSource == null)
        {
            var go = GameObject.Find("RemoteVoices/" + photonView.Owner.NickName);
            if (go != null)
            {
                audioSource = go.GetComponent<AudioSource>();
            }
            yield return new WaitForSeconds(2);
        }
    }
}
