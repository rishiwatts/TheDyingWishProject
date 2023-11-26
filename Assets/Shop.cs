using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour
{
    [SerializeField] AudioClip pressSound;
    [SerializeField] AudioClip denySound;
    [SerializeField] AudioClip openSound;
    [SerializeField] AudioClip closeSound;
    public GameObject attackComponentOfPlayer;
    public GameObject HUD;
    public GameObject dialogue;

    public Button HealthPotionAButton;
    public Button HealthPotionBButton;
    public Button AttackUpgradeButton;
    public GameObject potionTip;
    public bool potionsTip = false;

    // Start is called before the first frame update
    private void OnEnable()
    {
        dialogue.SetActive(false);
        NewPlayer.Instance.Freeze(true);     
        Cursor.visible = true;
        Time.timeScale = 0f;
        GameManager.Instance.audioSource.PlayOneShot(openSound);
    }
    IEnumerator pauseforSecond()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0f;
    }
    private void OnDisable()
    {
        dialogue.SetActive(true);
        Cursor.visible = false;
        NewPlayer.Instance.Freeze(false);
        GameManager.Instance.audioSource.PlayOneShot(closeSound);
        Time.timeScale = 1f;
        if (potionsTip == true)
            potionTip.SetActive(true);
    }
    public void CloseShop()
    {
        gameObject.SetActive(false);
    }
    public void HealthUpgradeA()
    {
        if (NewPlayer.Instance.coins >= 20)
        {
            GameManager.Instance.audioSource.PlayOneShot(pressSound);
            NewPlayer.Instance.coins -= 20;
            NewPlayer.Instance.potions += 1;
            HUD.GetComponent<HUD>().addHealthPotion(1);
            HealthPotionAButton.interactable = false;
        }
        else
        {
            GameManager.Instance.audioSource.PlayOneShot(denySound);
            return;
        }
    }
    public void HealthUpgradeB()
    {
        if (NewPlayer.Instance.coins >= 35)
        {
            GameManager.Instance.audioSource.PlayOneShot(pressSound);
            NewPlayer.Instance.coins -= 35;
            NewPlayer.Instance.potions += 2;
            HUD.GetComponent<HUD>().addHealthPotion(2);
            HealthPotionBButton.interactable = false;
        }
        else
        {
            GameManager.Instance.audioSource.PlayOneShot(denySound);
            return;
        }
    }

    public void AttackUpgrade()
    {
        if (NewPlayer.Instance.coins >= 10)
        {
            GameManager.Instance.audioSource.PlayOneShot(pressSound);
            NewPlayer.Instance.coins -= 10;
            HUD.GetComponent<HUD>().addRing(1);
            attackComponentOfPlayer.GetComponent<AttackHit>().hitPower += 1;
            AttackUpgradeButton.interactable = false;
        }
        else
        {
            GameManager.Instance.audioSource.PlayOneShot(denySound);
            return;
        }  
    }
   
}
