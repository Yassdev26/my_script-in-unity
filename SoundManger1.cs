using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManger : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;
    // Start is called before the first frame update
    void Start()
    {
       if (!PlayerPrefs.HasKey("musicVolume"))
       {
            PlayerPrefs.SetFloat ("musicVolume", 1);
            load();
       }
       else{
            load();
        }
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.volume = VolumeSlider.value;

            save();
    }
    private void load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void save()
    {
        PlayerPrefs.SetFloat("musicVolume", VolumeSlider.value);
    }
}
