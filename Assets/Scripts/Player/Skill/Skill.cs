using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class Skill : MonoBehaviour
{
    public SkillData skill;
    [SerializeField] GameObject upgradePanel;

    [SerializeField] TextMeshProUGUI skillNameText;
    [SerializeField] TextMeshProUGUI skillDescText;
    [SerializeField] Image skillCharacterProfileImage;
    [SerializeField] Image skillImage;
    int skillId;
    int skillCharacterNum;

    private void SkillUpdate()
    {
        skillNameText.text = skill.skillName + "\n" + "Lv." + skill.skillLevel;
        skillDescText.text = skill.skillDescription;
        skillImage.sprite = skill.skillImage;
        skillCharacterProfileImage.sprite = skill.skillCharacterImage;
        skillId = skill.ID;
        //skillCharacterProfileImage = skill;
    }
    public void SkillChoose()
    {
        skill = SkillManager.instance.SkillChoose();
        skillCharacterNum = SkillManager.instance.ReturnSkillCharacterNum();
        SkillUpdate();
    }
    public void SkillChooseOnClick()
    {
        UpgradeSkill();
        skill.skillLevel++;
        upgradePanel.transform.DOScale(Vector3.zero,0.1f);
    }
    private void UpgradeSkill()
    {
        if (skillId == 101) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 102) GameManager.instance.players[skillCharacterNum].fireRate *= 0.8f;
        else if (skillId == 103) GameManager.instance.players[skillCharacterNum].GetComponent<Cowboy>().shotGunBulletSkillLevel++;
        else if (skillId == 201) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 202) GameManager.instance.players[skillCharacterNum].maxBullet += 5;
        else if (skillId == 203) GameManager.instance.players[skillCharacterNum].GetComponent<Veteran>().FixMaxRandomDegree(-5);
        else if (skillId == 301) GameManager.instance.players[skillCharacterNum].maxBullet += 1;
        else if (skillId == 302) GameManager.instance.players[skillCharacterNum].GetComponent<Bazooka>().UpgradeExploseRadius(1.1f);
        else if (skillId == 303) GameManager.instance.players[skillCharacterNum].reloadingTime *= 0.8f;
        else if (skillId == 401) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 402) GameManager.instance.players[skillCharacterNum].attackRange *= 1.2f;
        else if (skillId == 403) GameManager.instance.players[skillCharacterNum].fireRate *= 0.8f;
        else if (skillId == 501) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 502) GameManager.instance.players[skillCharacterNum].fireRate *= 1.2f;
        else if (skillId == 503) GameManager.instance.players[skillCharacterNum].maxBullet++;
        else if (skillId == 601) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 602) GameManager.instance.players[skillCharacterNum].maxBullet++;
        else if (skillId == 603) GameManager.instance.players[skillCharacterNum].GetComponent<Iceman>().UpgradeSlowSkill();
        else if (skillId == 701) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 702) GameManager.instance.players[skillCharacterNum].maxBullet += 3;
        else if (skillId == 703) GameManager.instance.players[skillCharacterNum].GetComponent<Alien>().StunSkillUpgrade();
        else if (skillId == 801) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 802) GameManager.instance.players[skillCharacterNum].maxBullet += 5;
        else if (skillId == 803) GameManager.instance.players[skillCharacterNum].GetComponent<Veteran>().FixMaxRandomDegree(-3);
        else if (skillId == 901) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 902) GameManager.instance.players[skillCharacterNum].maxBullet += 5;
        else if (skillId == 903) GameManager.instance.players[skillCharacterNum].GetComponent<Veteran>().FixMaxRandomDegree(-3);
        else if (skillId == 1001) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 1002) GameManager.instance.players[skillCharacterNum].maxBullet += 5;
        else if (skillId == 1003) GameManager.instance.players[skillCharacterNum].GetComponent<Veteran>().FixMaxRandomDegree(-3);
        else if (skillId == 1101) GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
        else if (skillId == 1102) GameManager.instance.players[skillCharacterNum].maxBullet += 1;
        else if (skillId == 1103) GameManager.instance.players[skillCharacterNum].GetComponent<Jester>().PoisionTermUpgrade();

        //Final Skill
        if(skillId == 109)
        {
            GameManager.instance.players[skillCharacterNum].damage *= 1.5f;
            GameManager.instance.players[skillCharacterNum].fireRate *= 0.7f;
            GameManager.instance.players[skillCharacterNum].GetComponent<Cowboy>().penetrateCount = 10;
        }else if (skillId == 209)
        {
            GameManager.instance.players[skillCharacterNum].maxBullet = 99999;
            GameManager.instance.players[skillCharacterNum].damage *= 1.3f;
            GameManager.instance.players[skillCharacterNum].GetComponent<Veteran>().FixMaxRandomDegree(-10);
        }
        else if (skillId == 309)
        {
            GameManager.instance.players[skillCharacterNum].GetComponent<Bazooka>().UseFinalSkill();
        }else if (skillId == 409)
        {
            GameManager.instance.players[skillCharacterNum].attackRange = 100.0f;
            GameManager.instance.players[skillCharacterNum].damage *= 2f;
        }
        else if (skillId == 509)
        {
            GameManager.instance.players[skillCharacterNum].damage *= 1.5f;
            GameManager.instance.players[skillCharacterNum].GetComponent<Samurai>().isFinalSkillUpgrade = true;
        }else if (skillId == 609)
        {
            GameManager.instance.players[skillCharacterNum].GetComponent<Iceman>().UpgradeFinalSkill();
        }
        else if (skillId == 709)
        {
            GameManager.instance.players[skillCharacterNum].GetComponent<Alien>().UpgradeFinalSkill();
            GameManager.instance.players[skillCharacterNum].fireRate = 0.5f;
        }else if (skillId == 809)
        {

        }else if (skillId == 909)
        {
            GameManager.instance.players[skillCharacterNum].fireRate *= 0.5f;
            GameManager.instance.players[skillCharacterNum].maxBullet *= 2;
        }else if (skillId == 1009)
        {
            Debug.Log(skillCharacterNum);
            GameManager.instance.players[skillCharacterNum].GetComponent<Veteran>().penetrateCount = 10;
        }else if (skillId == 1109)
        {
            GameManager.instance.players[skillCharacterNum].GetComponent<Jester>().UpgradeFinalSkill();
        }

    }
    


}
