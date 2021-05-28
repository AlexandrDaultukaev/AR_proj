using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    bool VolumeFlag = true;
    Sprite SpriteVolumeOff, SpriteVolumeOn;
    public GameObject VolumeImage;
    public GameObject PanelAuth;
    public GameObject PanelHelp;
    public GameObject MenuButtons;
    public GameObject PanelsBanknotes;
    GameObject BankNote;
    // Start is called before the first frame update
    void Start()
    {
        SpriteVolumeOn = Resources.Load<Sprite>("VolumeOn");
        SpriteVolumeOff = Resources.Load<Sprite>("VolumeOff"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ShowPanelHelp() {
        MenuButtons.SetActive(false);
        PanelHelp.SetActive(true);
    }

    public void ClosePanelHelp() {
        PanelHelp.SetActive(false);
        MenuButtons.SetActive(true);
    }

    public void ShowPanelAuth() {
        MenuButtons.SetActive(false);
        PanelAuth.SetActive(true);
    }

    public void ClosePanelAuth() {
        PanelAuth.SetActive(false);
        MenuButtons.SetActive(true);
    }

    public void ShowIDPanelBanknote(int i) {
        PanelHelp.SetActive(false);
        BankNote = PanelsBanknotes.transform.GetChild(i).gameObject;
        BankNote.SetActive(true);
    }

    public void CloseIDPanelBanknote (int i) {
        BankNote = PanelsBanknotes.transform.GetChild(i).gameObject;
        BankNote.SetActive(false);
        PanelHelp.SetActive(true);
    }

    public void SetVolume() {
        if (VolumeFlag == true) {
            VolumeFlag = false;
            VolumeImage.GetComponent<Image>().sprite = SpriteVolumeOff;
            AudioListener.volume = 0;
        } else {
            VolumeFlag = true;
            VolumeImage.GetComponent<Image>().sprite = SpriteVolumeOn;
            AudioListener.volume = 1;
        }
    }
}