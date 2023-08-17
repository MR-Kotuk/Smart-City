using System.Collections;
using UnityEngine;
using TMPro;

public class HideTR : MonoBehaviour
{
    [SerializeField] private GameObject UIText;
    [SerializeField] private GameObject TextToDialoge;
    [SerializeField] private TMP_Text TextInDialoge;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject NoSeeCube;
    [SerializeField] private AudioSource TextRobotsSFX;

    [SerializeField] private Vector3 HydeHomePoint;

    private void Awake()
    {
        NoSeeCube.SetActive(false);
        TextToDialoge.SetActive(false);
        UIText.SetActive(false);
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "TRHyde")
        {
            UIText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Player.transform.position = HydeHomePoint;
                StartCoroutine(OnTrHideHome());
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "TRHyde")
            UIText.SetActive(false);
    }

    IEnumerator OnTrHideHome()
    {
        NoSeeCube.SetActive(true);
        TextToDialoge.SetActive(true);

        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: Hello, my name is Hyde. And you apparently B2.";
        yield return new WaitForSeconds(3);
        TextRobotsSFX.Play();
        TextInDialoge.text = "В2: Hello. I know this may sound strange, but... I would like you to answer a few questions for me.";
        yield return new WaitForSeconds(4);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: I'll tell you everything I know";
        yield return new WaitForSeconds(3);
        TextRobotsSFX.Play();
        TextInDialoge.text = "В2: What are these robots running down the street? And why are they chasing me, and you talk to me normally?!?!?...";
        yield return new WaitForSeconds(4);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: Before they were all like you and me.";
        yield return new WaitForSeconds(3);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: But at one point, a virus appeared.";
        yield return new WaitForSeconds(3);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: Someone snuck into headquarters and somehow reprogrammed the robots near the communications towers.";
        yield return new WaitForSeconds(5);
        TextRobotsSFX.Play();
        TextInDialoge.text = "В2: I'm sorry, but I don't understand much about towers and headquarters";
        yield return new WaitForSeconds(5);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: Headquarters is located in the main building. Which is located in the city center.";
        yield return new WaitForSeconds(5);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: This building has a battery that powers all the robots.";
        yield return new WaitForSeconds(4);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: And the communication towers are the towers that stand on the sides of the city. And maintain power from the main building";
        yield return new WaitForSeconds(5);
        TextRobotsSFX.Play();
        TextInDialoge.text = "В2: And now what?";
        yield return new WaitForSeconds(3);
        TextRobotsSFX.Play();
        TextInDialoge.text = "В2: Are we the only ones left uninfected, and will we just rust in this hole?";
        yield return new WaitForSeconds(4);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: No, there is one chance.";
        yield return new WaitForSeconds(3);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: You can sneak into headquarters and reprogram all the robots back.";
        yield return new WaitForSeconds(5);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: But for this you still need to turn on all the towers.";
        yield return new WaitForSeconds(4);
        TextRobotsSFX.Play();
        TextInDialoge.text = "B2: Well then, what are we waiting for? Why don't we go and do it?";
        yield return new WaitForSeconds(4);
        TextRobotsSFX.Play();
        TextInDialoge.text = "Hyde: I'm already rusty and can't do it. For me it's just suicide.";
        yield return new WaitForSeconds(4);
        TextRobotsSFX.Play();
        TextInDialoge.text = "B2: Well then there is no other way out. I have to go...";
        yield return new WaitForSeconds(4);

        TextToDialoge.SetActive(false);
        NoSeeCube.SetActive(false);
    }
}
