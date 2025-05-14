using TMPro;
using UnityEngine;

public class CountManager : MonoBehaviour
{
    private int counter;
    private float counterTime;
    private int power = 1;
    private int requeriedPower = 50;
    private int RequiriedToBot = 150;
    public TextMeshProUGUI textoCount;
    public TextMeshProUGUI requeriedPowerText;
    public TextMeshProUGUI requeriedToBotText;
    public Animator animButton;
    public Animator animText;
    public bool ifBot;
	private void Update()
	{
		textoCount.text = counter.ToString();
		requeriedPowerText.text = requeriedPower.ToString();
		requeriedToBotText.text = RequiriedToBot.ToString();
        //BotFunc();
        if(ifBot)
        {
            counterTime += Time.deltaTime;
            if(counter >= 100){
                AddCounter();
                counterTime = 0;
            }
        }
	}
	public void AddCounter()
    {
        counter += power;
        animButton.SetTrigger("TouchButton");
        animText.SetTrigger("TouchButton");
    }

    public void AddPower()
    {
        if(counter >= requeriedPower){
            counter -= requeriedPower;
            power ++;
            requeriedPower += requeriedPower/2;
        }
    }
    public void BuyBot(){
        if(counter >= RequiriedToBot){
            ifBot = true;
            counter -= RequiriedToBot;
        }
    }
}
