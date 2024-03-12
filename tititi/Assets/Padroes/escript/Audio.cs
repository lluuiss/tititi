using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderChanged);
    }

    // Update is called once per frame
    void Update()
    {
        //AudioManager.Instance.volume = volume.value;
    }

    private void OnVolumeSliderChanged(float volume)
    {
        //manda videos pro youtube
        //AudioObserveManager.VolumeChanged(volume);
    }
}

