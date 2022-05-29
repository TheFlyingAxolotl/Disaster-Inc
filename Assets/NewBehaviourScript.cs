using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject warningbrutal;
    public GameObject credits;
    public Slider bar;
    public Toggle toggle;
    public Toggle jokecheck;
    public Toggle shortagecheck;
    public Toggle sportcheck;
    public Toggle currentscheck;
    public Button VertFarm1;
    public Button VertFarm2;
    public Button VertFarm3;
    public Button VertFarm4;
    public Button VertFarm5;
    public Button fishFarm1;
    public Button fishFarm2;
    public Button nwater1;
    public Button nwater2;
    public Button nwater3;
    public Button nwater4;
    public Button nwater5;
    public Button desal1;
    public Button desal2;
    public Button desal3;
    public Button desal4;
    public Button wimport1;
    public Button wimport2;
    public Button wimport3;
    public Button wimport4;
    public Button fimport1;
    public Button fimport2;
    public Button fimport3;
    public Button fimport4;
    public Button fimport5;
    public Button fuel5;
    public Button fuel6;
    public Button solar1;
    public Button solar2;
    public Button h1;
    public Button h2;
    public Button h3;
    public Button h4;
    public Button h5;
    public Button c1;
    public Button c2;
    public Button c3;
    public Button c4;
    public Button c5;
    public Button fration1;
    public Button fration2;
    public Button fration3;
    public Button wration1;
    public Button wration2;
    public Button wration3;
    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public Button b5;
    public Button ch1;
    public Button ch2;
    public Button ch3;
    public Button ch4;
    public Button fw1;
    public Button fw2;
    public Button fw3;
    public Button fw4;
    public Button yes;   
    public Button FoodStor1;
    public Button FoodStor2;
    public Button FoodStor3;
    public Button FoodCam1;
    public Button FoodCam2;
    public Button FoodCam3;
    public Button LocalFarm1;
    public Button LocalFarm2;
    public Button LocalFarm3;
    public Button WaterStor1;
    public Button WaterStor2;
    public Button WaterStor3;
    public Button WaterCam1;
    public Button WaterCam2;
    public Button WaterCam3;
    public Button EnergyCam1;
    public Button EnergyCam2;
    public Button EnergyCam3;
    public Button solar3;
    public Button Edu1;
    public Button Edu2;
    public Button Ev1;
    public Button Ev2;
    public Button Ev3;
    public Button Ea1;
    public Button Ea2;
    public Button Ea3;
    public Button Warning1;
    public Button Warning2;
    public Button Warning3;
    public Button Seeding1;
    public Button Seeding2;
    public Button Seeding3;
    public Button Tempfw1;
    public Button Tempfw2;
    public Button Tempfw3;
    public Button newsbutton;
    public GameObject settings;
    public GameObject spanel;
    public GameObject events1;
    public GameObject choice;
    public GameObject GAME;
    public GameObject country;
    public GameObject sg;
    public GameObject sa;
    public GameObject gland;
    public GameObject mau;
    public GameObject info;
    public Button task;
    public GameObject techtree;
    public GameObject pop;
    public GameObject bonusButton;
    public Text valuem;
    public Text valuew;
    public Text valuee;
    public TMP_Text valuep;
    public TMP_Text eventtxt;
    public TMP_Text choicetxt;
    public TMP_Text eventtitle;
    public TMP_Text choicetitle;
    public TMP_Text ftxt;
    public TMP_Text wtxt;
    public TMP_Text dtxt;
    public TMP_Text etxt;
    public TMP_Text frtxt;
    public TMP_Text wrtxt;
    public TMP_Text title1;
    public TMP_Text desc;
    public TMP_Text det;
    public TMP_Text cost1;
    public TMP_Text yestxt;
    public TMP_Text notxt;
    public TMP_Text date;
    public TMP_Text news1;
    public TMP_Text news2;
    public TMP_Text news3;
    public TMP_Text news4;
    public TMP_Text news5;
    public TMP_Text endtxt;
    public TMP_Text enddesc;
    public TMP_Text newsText;
    public TMP_Text tutortxt;
    public Button foodButton;
    public GameObject tutorbox;
    public GameObject dates;
    public GameObject food;
    public GameObject water;
    public GameObject energy;
    public GameObject HnT;
    public GameObject ration;
    public GameObject tech;
    public GameObject info1;
    public GameObject money1;
    public GameObject water1;
    public GameObject energy1;
    public GameObject game;
    public GameObject alld;
    public GameObject deadd;
    public GameObject food2;
    public GameObject water2;
    public GameObject energy2;
    public GameObject subsidy;
    public GameObject ration2;
    public GameObject tech2;
    public GameObject gameend;
    public GameObject news;
    public GameObject circle;
    public GameObject nstar1;
    public GameObject nstar2;
    public GameObject nstar3;
    public GameObject sintro;
    public GameObject cover;
    public GameObject taskpanel;
    public GameObject summary;
    public GameObject eventinfo;
    public TMP_Text tasktxt;
    public TMP_Text timetxt;
    public TMP_Text tasktitle;
    public TMP_Text enddescri;
    public Button solar1p;
    public Button solar2p;
    string d;
    static int tutor = 1;
    int tut = 0;
    bool sportvalue = true;
    bool jokesvalue = true;
    bool shortagevalue = true;
    bool currentsvalue = true;
    float times = 1.0f;
    int newsCounter = 0;
    int solar2_level = 0;
    int x = 0;
    int moveX = 0;
    int moveY = 0;
    int randomTask1 = 0;
    int randomTask2 = 0;
    string foodCampaignSwitch = " ";
    string task1Status = "(-)";
    string task2Status = "(-)";
    string task4Status = "(-)";
    string EvSwitch = " ";
    public List<string> tutorials = new List<string>{};
    List<string> news6 = new List<string>{"", "", "", "", "", ""};
    public void checkSports(){
        sportvalue = sportcheck.isOn;
    }
    public void checkCurrents(){
        currentsvalue = currentscheck.isOn;
    }
    public void checkJokes(){
        jokesvalue = jokecheck.isOn;
    }
    public void checkShortage(){
        shortagevalue = shortagecheck.isOn;
    }
    public void openEventInfo(){
	eventinfo.SetActive(true);
    }
    public void closeEventInfo(){
	eventinfo.SetActive(false);
    }
    public void restartgame(){
	SceneManager.LoadScene("tech tree");
	chooseSg();
    }
    public void chooseMenu(){
	SceneManager.LoadScene("difficulty");
    }
    public void changeSpeed(){
	times = bar.value/10f;
	timetxt.text = times.ToString();
    }
    public void chooseWarningb(){
	warningbrutal.SetActive(true);
    }
    public void closeWarningb(){
	warningbrutal.SetActive(false);
    }

    public void chooseIntro(){
	SceneManager.LoadScene("introduction");
    }
    public void openIntroS(){
	sintro.SetActive(true);
    }
    public void closeIntroS(){
	sintro.SetActive(false);
    }
    public void openSummary(){
	summary.SetActive(true);
    }
    public void closeSummary(){
	summary.SetActive(false);
    }
    public void openTutorial(){
	if (tutor==1){
	    tutorbox.SetActive(true);
	    tutortxt.text = tutorials[tut];
	    tut++;
	    Time.timeScale = 0;
	}

	

    }

    public IEnumerator sweatntears() {
	   openTutorial();
	   yield return new WaitWhile(()=>tutorbox.activeSelf);
	   openTutorial();
	   yield return new WaitWhile(()=>tutorbox.activeSelf);
	   openTutorial();
	   yield return new WaitWhile(()=>tutorbox.activeSelf);
	   openTutorial();
	   yield return null;
    }

    public void openCredit(){
	credits.SetActive(true);
    }
    public void closeCredit(){
	credits.SetActive(false);
    }

    public void closeTutorial() {
	   tutorbox.SetActive(false);
       if (!choice.activeSelf & !events1.activeSelf)
       {
           Time.timeScale = times;
       }
    }


    public void closeTutor() {
	   tutor = 0;
	   toggle.isOn = false;
    }

    public void openSetting() {
	   spanel.SetActive(true);
	   Time.timeScale = 0;
    }

    public void closeSetting() {
	   spanel.SetActive(false);
       if (!events1.activeSelf & !choice.activeSelf & !taskpanel.activeSelf)
       {
          Time.timeScale = times;
       }
    }

    public void checkTutor(){
	  if (toggle.isOn) {
	     tutor = 1;
	  }
	  else {
	     tutor = 0;
	  }
    }

    public void closeCircle()
    {
	   circle.SetActive(false);
    }
    public void chooseFood()
    {
        food.SetActive(true);
        water.SetActive(false);
        energy.SetActive(false);
        HnT.SetActive(false);
        ration.SetActive(false);
        money1.transform.SetParent(food.transform);
	    water1.transform.SetParent(food.transform);
        energy1.transform.SetParent(food.transform);
        info1.transform.SetParent(food.transform);
    }

    public void chooseWater()
    {
        water.SetActive(true);
        food.SetActive(false);
        energy.SetActive(false);
        HnT.SetActive(false);
        ration.SetActive(false);
        money1.transform.SetParent(water.transform);
	    water1.transform.SetParent(water.transform);
        energy1.transform.SetParent(water.transform);
        info1.transform.SetParent(water.transform);
    }

    public void chooseEnergy()
    {
        energy.SetActive(true);
        water.SetActive(false);
        food.SetActive(false);
        HnT.SetActive(false);
        ration.SetActive(false);
        money1.transform.SetParent(energy.transform);
        water1.transform.SetParent(energy.transform);
        energy1.transform.SetParent(energy.transform);
        info1.transform.SetParent(energy.transform);
    }

    public void chooseHnT()
    {
        energy.SetActive(false);
        water.SetActive(false);
        food.SetActive(false);
        HnT.SetActive(true);
        ration.SetActive(false);
        money1.transform.SetParent(HnT.transform);
        water1.transform.SetParent(HnT.transform);
        energy1.transform.SetParent(HnT.transform);
        info1.transform.SetParent(HnT.transform);
    }

    public void chooseRation()
    {
        energy.SetActive(false);
        water.SetActive(false);
        food.SetActive(false);
        HnT.SetActive(false);
        ration.SetActive(true);
        money1.transform.SetParent(ration.transform);
        water1.transform.SetParent(ration.transform);
        energy1.transform.SetParent(ration.transform);
        info1.transform.SetParent(ration.transform);
    }

    public void chooseFood2()
    {
        food2.SetActive(true);
        water2.SetActive(false);
        energy2.SetActive(false);
        subsidy.SetActive(false);
        ration2.SetActive(false);
        money1.transform.SetParent(food2.transform);
        info1.transform.SetParent(food2.transform);
    }

    public void chooseWater2()
    {
        water2.SetActive(true);
        food2.SetActive(false);
        energy2.SetActive(false);
        subsidy.SetActive(false);
        ration2.SetActive(false);
        money1.transform.SetParent(water2.transform);
        info1.transform.SetParent(water2.transform);
    }

    public void chooseEnergy2()
    {
        energy2.SetActive(true);
        water2.SetActive(false);
        food2.SetActive(false);
        subsidy.SetActive(false);
        ration2.SetActive(false);
        money1.transform.SetParent(energy2.transform);
        info1.transform.SetParent(energy2.transform);
    }

    public void chooseSub()
    {
        energy2.SetActive(false);
        water2.SetActive(false);
        food2.SetActive(false);
        subsidy.SetActive(true);
        ration2.SetActive(false);
        money1.transform.SetParent(subsidy.transform);
        info1.transform.SetParent(subsidy.transform);
    }

    public void chooseRation2()
    {
        energy2.SetActive(false);
        water2.SetActive(false);
        food2.SetActive(false);
        subsidy.SetActive(false);
        ration2.SetActive(true);
        money1.transform.SetParent(ration2.transform);
        info1.transform.SetParent(ration2.transform);
    }

    public void openTech2()
    {
        tech2.SetActive(true);
        chooseFood2();
	    cover.SetActive(true);

	    Time.timeScale = 0;

        
    }

    public void displayDate()
    {
        date.text = d;
    }

    public void openNews(){
    Time.timeScale = 0;
    money1.SetActive(false);
    news.SetActive(true);
    circle.SetActive(false);
    newsCounter = news6.Count;
    news1.text = news6[newsCounter - 1];
    news2.text = news6[newsCounter - 2];
    news3.text = news6[newsCounter - 3];
    news4.text = news6[newsCounter - 4];
    news5.text = news6[newsCounter - 5];
    }
    public void closeNews(){
	news.SetActive(false);
	  if (!events1.activeSelf & !choice.activeSelf & !taskpanel.activeSelf) {
	    Time.timeScale = times;
	  }
      money1.SetActive(true);
    }
    public void closeTech2()
    {
        tech2.SetActive(false);
        chooseFood2();
        food2.SetActive(false);
        money1.transform.SetParent(game.transform);
	    info.SetActive(false);
	    cover.SetActive(false);
	    if (!events1.activeSelf & !choice.activeSelf & !taskpanel.activeSelf){
	      Time.timeScale = times;
	    }
    }

    public void closeTech()
    {
        tech.SetActive(false);
        info.SetActive(false);
        chooseFood();
        food.SetActive(false);
        money1.transform.SetParent(game.transform);
        settings.SetActive(true);
        task.gameObject.SetActive(true);
        techtree.SetActive(true);
        pop.SetActive(true);
        dates.SetActive(true);
        alld.SetActive(true);
        deadd.SetActive(true);
        d = new DateTime(2030, 01, 01).ToString("yyyy-MM-dd");
        displayDate();
        StartCoroutine(gamePlay());
        x += 1;
        checkSolar();
        newsbutton.gameObject.SetActive(true);
        printrest(Convert.ToInt32(100 + additionalFoodProduced).ToString(), (Convert.ToInt32(100 + additionalWaterProduced)).ToString(), (Convert.ToInt32(100 + additionalEnergyProduced)).ToString(), "0");
        printration((additionalFoodSupplied).ToString(), (additionalWaterSupplied).ToString());
        tutorbox.transform.Translate(0, 7, 0);
    }
    
    public void openDevBonus()
    {
        bonusButton.gameObject.SetActive(true);
        moveX = rnd.Next(-180, 181);
        moveY = rnd.Next(-65, 66);
        bonusButton.gameObject.transform.Translate(moveX, moveY, 0);
    }

    public void closeDevBonus()
    {
        bonusButton.gameObject.transform.Translate(-moveX, -moveY, 0);
        bonusButton.gameObject.SetActive(false);
        money += rnd.Next(3, 6);
        valuem.text = money.ToString() + " development points";
        if (times >= 2) 
        {
            task1Status = "(completed)";
        }
    }

    Dictionary<string, List<string>> descs = new Dictionary<string, List<string>>()
  {
    { "VerticalFarms(I)", new List<string>(){"Vertical farms will be built in Singapore. These will be used to grow leafy vegetables, microgreens, and herbs. This upgrade will increase local food production by 1%.","","50","0","0"}},
    { "VerticalFarms(II)", new List<string>(){"Vertical farms will be built in Singapore. These will be used to grow leafy vegetables, microgreens, and herbs. This upgrade will increase local food production by 2%.", "", "80","0","0"}},
    { "VerticalFarms(III)", new List<string>(){"Vertical farms will be built in Singapore. These will be used to grow leafy vegetables, microgreens, and herbs. This upgrade will increase local food production by 3%.", "", "100","0","0"}},
    { "VerticalFarms(IV)", new List<string>(){"Floating vertical farms will be off the coast of Singapore. These will be used to grow leafy vegetables, microgreens, and herbs. This upgrade will increase local food production by 1.5%.", "", "100","0","0"}},
    { "VerticalFarms(V)", new List<string>(){"Floating vertical farms will be off the coast of Singapore. These will be used to grow leafy vegetables, microgreens, and herbs. This upgrade will increase local food production by 3%.", "", "160","0","0"}},
    { "FishFarms(I)", new List<string>(){"Fish farms will be built in and off the coast of Singapore. Both freshwater and saltwater fish will be reared. This upgrade will increase local food production by 1.75%.", "", "50","0","0"}},
    { "FishFarms(II)", new List<string>(){"Fish farms will be built in and off the coast of Singapore. Both freshwater and saltwater fish will be reared. This upgrade will increase local food production by 1.25%.", "", "50","0","0"}},
    { "FoodRations(I)", new List<string>(){"Dry food items will be purchased and stored for emergencies. This upgrade involves the storage of 15 days worth of food.","","40","0","0"}},
    { "FoodRations(II)", new List<string>(){"Dry food items food will be purchased and stored for emergencies. This upgrade involves the storage of 15 days worth of food.", "","40","0","0"}},
    { "FoodRations(III)", new List<string>(){"Dry food items food will be purchased and stored for emergencies. This upgrade involves the storage of 15 days worth of food.", "","40","0","0"}},
    { "RecycledWater(V)", new List<string>(){"Water recycling plants will be built in Singapore. This upgrade will increase local water production by 15%.", "", "100","0","0"}},
    { "Desalination(IV)", new List<string>(){"Water desalination plants will be built in Singapore. This upgrade will increase local water production by 20%.", "", "200","0","0"}},
    { "WaterImports(III)", new List<string>(){"Contracts will be made with neighbouring countries to allow Singapore to import more water from them. This upgrade will increase local water supply by 6%.","","60","0","0"}},
    { "WaterImports(IV)", new List<string>(){"Contracts will be made with neighbouring countries to allow Singapore to import more water from them. This upgrade will increase local water supply by 12%.", "","120","0","0"}},
    { "WaterRations(I)", new List<string>(){"Water will be bottled and stored for emergencies. This upgrade involves the storage of 15 days worth of water.","","15","0","0"}},
    { "WaterRations(II)", new List<string>(){"Water will be bottled and stored for emergencies. This upgrade involves the storage of 15 days worth of water.","","15","0","0"}},
    { "WaterRations(III)", new List<string>(){"Water will be bottled and stored for emergencies. This upgrade involves the storage of 15 days worth of water.","","15","0","0"}},
    { "FossilFuels(V)", new List<string>(){"More fossil fuel power stations will be built in Singapore. This upgrade will increase local energy production by 20%.","","100","0","0"}},
    { "FossilFuels(VI)", new List<string>(){"More fossil fuel power stations will be built in Singapore. This upgrade will increase local energy production by 20%.", "","100","0","0"}},
    { "SolarEnergy(I)", new List<string>(){"Solar panels will be installed in Singapore. This upgrade will increase local energy production by 10% and is popular among the environmetally conscious.","","100","0","0"}},
    { "SolarEnergy(II)", new List<string>(){"Solar panels will be installed off the coast of Singapore. This upgrade will increase local energy production by 10% and is popular among the environmetally conscious.", "", "100","0","0"}},
    { "Channels(III)", new List<string>(){"Water channels in Singapore will be widened to increase their water storage capacity by 20%. This will help to prevent and reduce the impact of flash floods.","","30","0","0"}},
    { "Channels(IV)", new List<string>(){"Water channels in Singapore will be widened to increase their water storage capacity by 20%. This will help to prevent and reduce the impact of flash floods.","","30","0","0"}},
    { "FloodWalls(III)", new List<string>(){"Flood walls will be installed along river banks and channels to increase their water storage capacity by 20%.","","30","0","0"}},
    { "FloodWalls(IV)", new List<string>(){"Flood walls will be installed along river banks and channels to increase their water storage capacity by 20%.", "","30","0","0"}},
    { "FoodStorage(I)", new List<string>(){"Surplus food will be frozen and stored for emergencies. This upgrade involves the storage of 15 days worth of food.", "","25","0","0"}},
    { "FoodStorage(II)", new List<string>(){"Surplus food will be frozen and stored for emergencies. This upgrade involves the storage of 15 days worth of food.", "","25","0","0"}},
    { "FoodStorage(III)", new List<string>(){"Surplus food will be frozen and stored for emergencies. This upgrade involves the storage of 15 days worth of food.", "","25","0","0"}},
    { "FoodCampaigns(I)", new List<string>(){"Campaigns will be started to get Singaporeans to waste less food. This upgrade will decrease local food demand by about 2.5%.","","40","0","0"}},
    { "FoodCampaigns(II)", new List<string>(){"Efforts to get Singaporeans to waste less food will be renewed and furthered. This upgrade will decrease local food demand by about 1.5%.", "","40","0","0"}},
    { "FoodCampaigns(III)", new List<string>(){"Efforts to get Singaporeans to waste less food will be renewed and furthered. This upgrade will decrease local food demand by about 0.50%.", "","40","0","0"}},
    { "LocalFarms(I)", new List<string>(){"Money will be given to local farms to help them expand their operations. Locals will also be encouraged to eat local produce. This upgrade will increase local food production by about 1.5%.","","70","5","0"}},
    { "LocalFarms(II)", new List<string>(){"Even more money will be given to local farms to help them expand their operations. This upgrade will increase local food production by about 1.25%.", "","70","0","0"}},
    { "LocalFarms(III)", new List<string>(){"Even more money will be given to local farms to help them expand their operations. This upgrade will increase local food production by about 1.0%.", "","70","0","0"}},
    { "WaterStorage(I)", new List<string>(){"Surplus water will be bottled and stored for emergencies. This upgrade involves the storage of 15 days worth of water.", "","10","0","0"}},
    { "WaterStorage(II)", new List<string>(){"Surplus water will be bottled and stored for emergencies. This upgrade involves the storage of 15 days worth of water.", "","10","0","0"}},
    { "WaterStorage(III)", new List<string>(){"Surplus water will be bottled and stored for emergencies. This upgrade involves the storage of 15 days worth of water.", "","10","0","0"}},
    { "WaterCampaigns(I)", new List<string>(){"Campaigns will be started to get Singaporeans to waste less water. This upgrade will decrease local water usage by about 1.50%.", "","40","0","0"}},
    { "WaterCampaigns(II)", new List<string>(){"Efforts to get Singaporeans to waste less water will be renewed and furthered. This upgrade will decrease local water usage by about 1.0%.", "","40","0","0"}},
    { "WaterCampaigns(III)", new List<string>(){"Efforts to get Singaporeans to waste less water will be renewed and furthered. This upgrade will decrease local water usage by about 0.50%.", "","40","0","0"}},
    { "EnergyCampaigns(I)", new List<string>(){"Campaigns will be started to get Singaporeans to waste less energy. This upgrade will decrease local electricty usage by about 2.0%.", "","40","0","0"}},
    { "EnergyCampaigns(II)", new List<string>(){"Efforts to get Singaporeans to waste less energy will be renewed and furthered. This upgrade will decrease local electricty usage by about 1.25%.", "","40","0","0"}},
    { "EnergyCampaigns(III)", new List<string>(){"Efforts to get Singaporeans to waste less energy will be renewed and furthered. This upgrade will decrease local electricty usage by about 0.50%.", "","40","0","0"}},
    { "SolarPanels(I)", new List<string>(){"Solar panels will be installed in Singapore. This upgrade will increase local energy production by 1.5%.", "","40","0","0"}},
    { "SolarPanels(II)", new List<string>(){"Solar panels will be installed in Singapore. This upgrade will increase local energy production by 1.5%.", "","30","0","0"}},
    { "SolarPanels(III)", new List<string>(){"Solar panels will be installed in Singapore. This upgrade will increase local energy production by 1.5%.", "","20","0","0"}},
    { "Education(I)", new List<string>(){"Students will be taught how to identify and treat heat injuries in schools.", ""," 5","0","0"}},
    { "Education(II)", new List<string>(){"A public campaign will be started to educate Singaporeans on how they can identify and treat heat injuries.","","10","0","0"}},
    { "WarningSystems(I)", new List<string>(){"Along with more water-level sensors being placed in channels, flood prediction algorithms will be developed. Relevant information will be made known to the public.", "","20","0","0"}},
    { "WarningSystems(II)", new List<string>(){"An app will be developed to enable citizens to see the risk of flooding at different placlocationses at different times. Additionally, flood prediction algorithms will be enhanced.", "","30","0","0"}},
    { "WarningSystems(III)", new List<string>(){"The amount of water-level data collected will be increased. Additionally, flood prediction algorithms will be enhanced.", "","40","0","0"}},
    { "TemporaryFloodWalls(I)", new List<string>(){"Flood walls will be installed around channels to temporarily increase their capacity by 20%.","","10","0","0"}},
    { "TemporaryFloodWalls(II)", new List<string>(){"Taller flood walls will be installed around channels to temporarily increase their capacity by another 20%.","","20","0","0"}},
    { "TemporaryFloodWalls(III)", new List<string>(){"Taller flood walls will be installed around channels to temporarily increase their capacity by another 20%.", "","30","0","0"}},
    { "CloudSeeding(I)", new List<string>(){"Cloud seeding will be employed once a week during drought periods. This will lessen the effects of droughts on Singapore.", ""," 5","0","0"}},
    { "CloudSeeding(II)", new List<string>(){"Cloud seeding will be employed three times a week during drought periods. This will lessen the effects of droughts on Singapore.", "","10","0","0"}},
    { "CloudSeeding(III)", new List<string>(){"Cloud seeding will be employed daily during drought periods. This will lessen the effects of droughts on Singapore.", "","20","0","0"}},
    { "SubsidiseEVs(I)", new List<string>(){"Singaporeans will be given subsidies when they purchase electric vehicles. This will encourage more Singaporeans to purchase electric cars.", "","30","0","0"}},
    { "SubsidiseEVs(II)", new List<string>(){"Singaporeans will be given even more subsidies when they purchase electric vehicles. This will encourage even more Singaporeans to purchase electric cars.", "","45","0","0"}},
    { "SubsidiseEVs(III)", new List<string>(){"Singaporeans will be given even more subsidies when they purchase electric vehicles. This will encourage even more Singaporeans to purchase electric cars.", "","60","0","0"}},
    { "Eco-FriendlyAppliances(I)", new List<string>(){"Singaporeans will be given subsidies when they purchase eco-friendly electrical appliances. This will encourage more Singaporeans to go green.", "","15","0","0"}},
    { "Eco-FriendlyAppliances(II)", new List<string>(){"Singaporeans will be even more subsidies when they purchase eco-friendly electrical appliances. This will encourage even more Singaporeans to go green.", "","25","0","0"}},
    { "Eco-FriendlyAppliances(III)", new List<string>(){"Singaporeans will be even more subsidies when they purchase eco-friendly electrical appliances. This will encourage even more Singaporeans to go green.","","35","0","0"}}
  };
    string b;
    string opt = "";




    static int difficulty = 1;
    int money = 650;
    int additionalFoodSupplied = 0;
    int additionalWaterSupplied = 0;
    double additionalFoodProduced = 0;
    double additionalWaterProduced = 0;
    double additionalEnergyProduced = 0;
    private int fossilFuel_level = 5;
    private int solar_level = 1;
    int channels = 3;
    System.Random rnd = new System.Random();
    double campaignEffectiveness1 = 0;
    double localFarmsResult1 = 0;
    double campaignEffectiveness = 0;
    double localFarmsResult = 0;
    double arbitary = 0;
    double floodDeathReduce = 0;
    int warningSystemDay = 0;
    double floodDeathReduce1 = 0;
    int floodWallDay = 0;
    double educationReduce = 0;
    int educationDay = 0;
    int ecoFriendlySubsidies = 0;    
    int[] floodRequirement = { 10, 50, 120 };
    int[] heatWaveRequirement = { 14, 100, 260 };
    int ecoFriendlyInitiative = 0;
    int waterPlusDuringDrought = 0;
    double foodDemand = 100;
    double waterDemand = 100;
    double energyDemand = 100;
    double energyDemandMinus = 0;
    System.Text.StringBuilder taskDescription = new System.Text.StringBuilder("");
    int totalHeatWaveDeaths = 0;
    int totalFloodDeaths = 0;

    public void printm()
    {
        valuem.text = money.ToString() + " development points";
    }

    public void printothers()
    {
        popularity = System.Math.Round(popularity, 2);
        valuep.text = "Approval: " + popularity + "%";
        d = new DateTime(2030, 01, 01).AddDays(day).ToString("yyyy-MM-dd");
        date.text = d;
    }
    public void printrest(string f, string w, string e, string d)
    {
        ftxt.text = "Food sufficiency: " + Convert.ToString(Convert.ToInt32(f)) + "%";
        wtxt.text = "Water sufficiency: " + Convert.ToString(Convert.ToInt32(w)) + "%";
        etxt.text = "Energy sufficiency: " + Convert.ToString(Convert.ToInt32(e)) + "%";
        dtxt.text = "Dead: " + d;
    }
    public void printration(string f, string w)
    {
        frtxt.text = Convert.ToString(Convert.ToInt32(f)) + " rations";
        wrtxt.text = Convert.ToString(Convert.ToInt32(w)) + " rations";
    }

    public void chooseNormal()
    {
        SceneManager.LoadScene("tech tree");
        difficulty = 1;
    }

    public void chooseHard()
    {
        SceneManager.LoadScene("tech tree");
        difficulty = 2;
    }

    public void chooseBrutal()
    {
        SceneManager.LoadScene("tech tree");
        difficulty = 3;
    }

    public void chooseSg()
    {
        country.SetActive(false);
        GAME.SetActive(true);
        sg.SetActive(true);
        sa.SetActive(false);
        gland.SetActive(false);
        mau.SetActive(false);
        bonusButton.SetActive(false);
        f_import1();
        f_import2();
        f_import3();
        f_import4();
        f_import5();
        n_water1();
        n_water2();
        n_water3();
        n_water4();
        desal_1();
        desal_2();
        desal_3();
        w_import1();
        w_import2();
        H1();
        H2();
        H3();
        H4();
        H5();
        C1();
        C2();
        C3();
        C4();
        C5();
        B1();
        B2();
        B3();
        B4();
        B5();
        CH1();
        CH2();
        F_wall1();
        F_wall2();
        money = 650;
        randomTask1 = rnd.Next(3);
        randomTask2 = rnd.Next(3, 6);        


        if (tutor==1) {
	        tutorials.Add("\nIt's the year 2028 and you are the leader of Singapore. Natural disasters are set to ravage Singapore. These disasters will negatively impact Singapore's food, water and energy supply.");
            tutorials.Add("\nThis is the upgrade tree. All upgrades made here can help to reduce the impacts of the upcoming disasters. You can make upgrades by clicking on the icons and then on the 'upgrade' button.");
    	    tutorials.Add("\nOnce you're done with your infrastructure upgrades, click on the 'done' button to move on to the next stage of the game.");
    	    tutorials.Add("\nDevelopment points which you do not use up in this stage can be used in the next stage of the game.");
    	    tutorials.Add("\nThe 2nd stage of the game has begun and disasters will be coming. To counter these disasters, you can make more upgrades. To access these upgrades, click on the 'Upgrades' button located on the left side of the screen.");
    	    tutorials.Add("\nYou will get developments points throughout the game. Water shortages and power outages will reduce the number of development points you get. Clicking on the green pop-ups will give you extra development points.");
    	    tutorials.Add("\nAt the end of your term, you will get a score which will be your approval rating rounded to the nearest whole number. Completing each task will increase your score by 1. To ace the game, you will need a score of 75.");
    	    tutorials.Add("\nThe game ends at the end of 2033. You can access the settings (bottom right corner) and tailor the game to suit your playstyle. All feedback would be appreciated and you can contact us at techmacrophage@gmail.com.");
	        StartCoroutine(sweatntears());
	    }
    }

    public void chooseSa()
    {
        country.SetActive(false);
        GAME.SetActive(true);
        sa.SetActive(true);
        sg.SetActive(false);
        gland.SetActive(false);
        mau.SetActive(false);
    }

    public void chooseGland()
    {
        country.SetActive(false);
        GAME.SetActive(true);
        sg.SetActive(false);
        sa.SetActive(false);
        gland.SetActive(true);
        mau.SetActive(false);
    }

    public void chooseMau()
    {
        country.SetActive(false);
        GAME.SetActive(true);
        sg.SetActive(false);
        sa.SetActive(false);
        gland.SetActive(false);
        mau.SetActive(true);
    }

    public void closeInfo()
    {
        info.SetActive(false);
    }

    public void openInfo()
    {
        info.SetActive(true);
    }

    public void apressed(Button btn)
    {
        openInfo();
        b = btn.name;
        title1.text = b;
        b = b.Replace(" ", "");
        desc.text = descs[b][0];
        if (money < Int16.Parse(descs[b][2]))
        {
            cost1.text = "Insufficient development points (" + descs[b][2] + ")";
        }
        else
        {
            cost1.text = descs[b][2] + " development points ";
        }

        if (b == "FoodCampaigns(I)" || b == "FoodCampaigns(II)" || b == "FoodCampaigns(III)")
        {
            if (foodCampaignSwitch == "on")
            {
                cost1.text = "Upgrade unavailable now (" + descs[b][2] + ")";
            }
        }
    }

    public void Vert_Farm1()
    {
        VertFarm2.gameObject.SetActive(true);
        VertFarm1.interactable = false;
        additionalFoodProduced += 1;
        money -= 50;
        printm();
    }

    public void Vert_Farm2()
    {
        VertFarm3.gameObject.SetActive(true);
        VertFarm2.interactable = false;
        additionalFoodProduced += 2;
        money -= 80;
        printm();

    }

    public void Vert_Farm3()
    {
        VertFarm4.gameObject.SetActive(true);
        VertFarm3.interactable = false;
        additionalFoodProduced += 3;
        money -= 100;
        printm();
    }

    public void Vert_Farm4()
    {
        VertFarm5.gameObject.SetActive(true);
        VertFarm4.interactable = false;
        additionalFoodProduced += 1.5;
        money -= 100;
        printm();
    }

    public void Vert_Farm5()
    {
        VertFarm5.interactable = false;
        additionalFoodProduced += 3;
        money -= 160;
        printm();
    }

    public void fish_Farm1()
    {
        fishFarm2.gameObject.SetActive(true);
        fishFarm1.interactable = false;
        additionalFoodProduced += 1.75;
        money -= 50;
        printm();
    }

    public void fish_Farm2()
    {
        fishFarm2.interactable = false;
        additionalFoodProduced += 1.25;
        money -= 50;
        printm();
    }

    public void n_water1()
    {
        nwater2.gameObject.SetActive(true);
        nwater1.interactable = false;
        printm();
    }
    public void n_water2()
    {
        nwater3.gameObject.SetActive(true);
        nwater2.interactable = false;
        printm();
    }

    public void n_water3()
    {
        nwater4.gameObject.SetActive(true);
        nwater3.interactable = false;
        printm();
    }

    public void n_water4()
    {
        nwater5.gameObject.SetActive(true);
        nwater4.interactable = false;
        printm();
    }

    public void n_water5()
    {
        nwater5.interactable = false;
        additionalWaterProduced += 15;
        money -= 100;
        printm();
    }

    public void desal_1()
    {
        desal2.gameObject.SetActive(true);
        desal1.interactable = false;
        printm();
    }

    public void desal_2()
    {
        desal3.gameObject.SetActive(true);
        desal2.interactable = false;
        printm();
    }

    public void desal_3()
    {
        desal4.gameObject.SetActive(true);
        desal3.interactable = false;
        printm();
    }

    public void desal_4()
    {
        desal4.interactable = false;
        additionalWaterProduced += 20;
        money -= 200;
        printm();
    }

    public void w_import1()
    {
        wimport2.gameObject.SetActive(true);
        wimport1.interactable = false;
        printm();
    }

    public void w_import2()
    {
        wimport3.gameObject.SetActive(true);
        wimport2.interactable = false;
        printm();
    }

    public void w_import3()
    {
        wimport4.gameObject.SetActive(true);
        wimport3.interactable = false;
        additionalWaterProduced += 6;
        money -= 60;
        printm();
    }

    public void w_import4()
    {
        wimport4.interactable = false;
        additionalWaterProduced += 12;
        money -= 120;
        printm();
    }

    public void f_import1()
    {
        fimport2.gameObject.SetActive(true);
        fimport1.interactable = false;
        printm();
    }

    public void f_import2()
    {
        fimport3.gameObject.SetActive(true);
        fimport2.interactable = false;
        printm();
    }

    public void f_import3()
    {
        fimport4.gameObject.SetActive(true);
        fimport3.interactable = false;
        printm();
    }

    public void f_import4()
    {
        fimport5.gameObject.SetActive(true);
        fimport4.interactable = false;
        printm();
    }

    public void f_import5()
    {
        fimport5.interactable = false;
        printm();
    }

    public void H1()
    {
        h2.gameObject.SetActive(true);
        h1.interactable = false;
        printm();
    }

    public void H2()
    {
        h3.gameObject.SetActive(true);
        h2.interactable = false;
        printm();
    }

    public void H3()
    {
        h4.gameObject.SetActive(true);
        h3.interactable = false;
        printm();
    }

    public void H4()
    {
        h5.gameObject.SetActive(true);
        h4.interactable = false;
        printm();
    }

    public void H5()
    {
        h5.interactable = false;
        printm();
    }

    public void C1()
    {
        c2.gameObject.SetActive(true);
        c1.interactable = false;
        printm();
    }

    public void C2()
    {
        c3.gameObject.SetActive(true);
        c2.interactable = false;
        printm();
    }

    public void C3()
    {
        c4.gameObject.SetActive(true);
        c3.interactable = false;
        printm();
    }

    public void C4()
    {
        c5.gameObject.SetActive(true);
        c4.interactable = false;
        printm();
    }

    public void C5()
    {
        c5.interactable = false;
        printm();
    }

    public void f_ration1()
    {
        fration2.gameObject.SetActive(true);
        fration1.interactable = false;
        additionalFoodSupplied += 15;
        money -= 40;
        printm();
    }

    public void f_ration2()
    {
        fration3.gameObject.SetActive(true);
        fration2.interactable = false;
        additionalFoodSupplied += 15;
        money -= 40;
        printm();
    }

    public void f_ration3()
    {
        fration3.interactable = false;
        additionalFoodSupplied += 15;
        money -= 40;
        printm();
    }

    public void w_ration1()
    {
        wration2.gameObject.SetActive(true);
        wration1.interactable = false;
        additionalWaterSupplied += 15;
        money -= 15;
        printm();
    }

    public void w_ration2()
    {
        wration3.gameObject.SetActive(true);
        wration2.interactable = false;
        additionalWaterSupplied += 15;
        money -= 15;
        printm();
    }

    public void w_ration3()
    {
        wration3.interactable = false;
        additionalWaterSupplied += 15;
        money -= 15;
        printm();
    }

    public void fuel_5()
    {
        fuel6.gameObject.SetActive(true);
        fuel5.interactable = false;
        additionalEnergyProduced += 20;
        money -= 100;
        fossilFuel_level += 1;
        printm();
    }

    public void fuel_6()
    {
        fuel6.interactable = false;
        additionalEnergyProduced += 20;
        money -= 100;
        fossilFuel_level += 1;
        printm();
    }

    public void solar_2()
    {
	    solar3.gameObject.SetActive(true);
        solar2.interactable = false;
	    money -= 100;
        solar_level += 1;
	    additionalEnergyProduced += 10;
        printm();
    }

    public void solar_1()
    {
        solar2.gameObject.SetActive(true);
        solar1.interactable = false;
	    money -= 100;
        solar_level += 1;
        additionalEnergyProduced += 10;
        printm();
    }
    public void solar_3()
    {
        solar3.interactable = false;
        additionalEnergyProduced += 1.5;
	    solar2_level += 1;
        money -= 20;
        printm();
    }
    public void solar_1p()
    {
        solar1p.interactable = false;
	    solar2p.gameObject.SetActive(true);
        additionalEnergyProduced += 1.5;
	    solar2_level += 1;
        money -= 40;
        printm();
    }
    public void solar_2p()
    {
        solar2p.interactable = false;
	    solar3.gameObject.SetActive(true);
        additionalEnergyProduced += 1.5;
	    solar2_level += 1;
        money -= 30;
        printm();
    }

    public void B1()
    {
        b2.gameObject.SetActive(true);
        b1.interactable = false;
        printm();
    }

    public void B2()
    {
        b3.gameObject.SetActive(true);
        b2.interactable = false;
        printm();
    }

    public void B3()
    {
        b4.gameObject.SetActive(true);
        b3.interactable = false;
        printm();
    }

    public void B4()
    {
        b5.gameObject.SetActive(true);
        b4.interactable = false;
        printm();
    }

    public void B5()
    {
        b5.interactable = false;
        printm();
    }

    public void CH1()
    {
        ch2.gameObject.SetActive(true);
        ch1.interactable = false;
        printm();
    }

    public void CH2()
    {
        ch3.gameObject.SetActive(true);
        ch2.interactable = false;
        printm();
    }

    public void CH3()
    {
        ch4.gameObject.SetActive(true);
        ch3.interactable = false;
        channels += 1;
        money -= 30;
        printm();
    }

    public void CH4()
    {
        ch4.interactable = false;
        channels += 1;
        money -= 30;
        printm();
    }

    public void F_wall1()
    {
        fw2.gameObject.SetActive(true);
        fw1.interactable = false;
        printm();
    }

    public void F_wall2()
    {
        fw3.gameObject.SetActive(true);
        fw2.interactable = false;
        channels += 1;
        money -= 30;
        printm();
    }

    public void F_wall3()
    {
        fw4.gameObject.SetActive(true);
        fw3.interactable = false;
        channels += 1;
        money -= 30; 
        printm();
    }

    public void F_wall4()
    {
        fw4.interactable = false;
        printm();
    }
    public void Food_Stor1()
    {
        FoodStor2.gameObject.SetActive(true);
        FoodStor1.interactable = false;
        additionalFoodSupplied += 15;
        money -= 25;
        printm();
    }

    public void Food_Stor2()
    {
        FoodStor3.gameObject.SetActive(true);
        FoodStor2.interactable = false;
        additionalFoodSupplied += 15;
        money -= 25;
        printm();

    }

    public void Food_Stor3()
    {
        FoodStor3.interactable = false;
        additionalFoodSupplied += 15;
        money -= 25;
        printm();
    }

    public void Food_Cam1()
    {
        FoodCam2.gameObject.SetActive(true);
        FoodCam1.interactable = false;
        foodDemand -= 2.5;
        money -= 40;
        printm();
    }

    public void Food_Cam2()
    {
        FoodCam3.gameObject.SetActive(true);
        FoodCam2.interactable = false;
        foodDemand -= 1.5;
        money -= 40;
        printm();
    }

    public void Food_Cam3()
    {
        FoodCam3.interactable = false;
        campaignEffectiveness1 = rnd.Next(25, 76);
        foodDemand -= 0.5;
        money -= 40;
        printm();
    }
    public void L_Farm1()
    {
        LocalFarm2.gameObject.SetActive(true);
        LocalFarm1.interactable = false;
        additionalFoodProduced += 1.5;
        money -= 70;
        printm();
    }

    public void L_Farm2()
    {
        LocalFarm3.gameObject.SetActive(true);
        LocalFarm2.interactable = false;
        localFarmsResult1 = rnd.Next(110, 141);
        additionalFoodProduced += 1.25;
        money -= 70;
        printm();

    }

    public void L_Farm3()
    {
        LocalFarm3.interactable = false;
        localFarmsResult1 = rnd.Next(90, 111);
        localFarmsResult = localFarmsResult1 / 100;
        additionalFoodProduced += 1;
        money -= 70;
        printm();
    }

    public void W_Stor1()
    {
        WaterStor2.gameObject.SetActive(true);
        WaterStor1.interactable = false;
        additionalWaterSupplied += 15;
        money -= 10;
        printm();
    }

    public void W_Stor2()
    {
        WaterStor3.gameObject.SetActive(true);
        WaterStor2.interactable = false;
        additionalWaterSupplied += 15;
        money -= 10;
        printm();

    }

    public void W_Stor3()
    {
        WaterStor3.interactable = false;
        additionalWaterSupplied += 15;
        money -= 10;
        printm();
    }    
    public void W_Cam1()
    {
        WaterCam2.gameObject.SetActive(true);
        WaterCam1.interactable = false;
        campaignEffectiveness1 = rnd.Next(100, 201);
        campaignEffectiveness = campaignEffectiveness1 / 100;
        waterDemand -= campaignEffectiveness;
        money -= 40;
        printm();
    }

    public void W_Cam2()
    {
        WaterCam3.gameObject.SetActive(true);
        WaterCam2.interactable = false;
        campaignEffectiveness1 = rnd.Next(70, 131);
        campaignEffectiveness = campaignEffectiveness1 / 100;
        waterDemand -= campaignEffectiveness;
        money -= 40;
        printm();
    }

    public void W_Cam3()
    {
        WaterCam3.interactable = false;
        campaignEffectiveness1 = rnd.Next(30, 70);
        campaignEffectiveness = campaignEffectiveness1 / 100;
        waterDemand -= campaignEffectiveness;
        money -= 40;
        printm();
    }  

    public void E_Cam1()
    {
        EnergyCam2.gameObject.SetActive(true);
        EnergyCam1.interactable = false;
        campaignEffectiveness1 = rnd.Next(150, 251);
        campaignEffectiveness = campaignEffectiveness1 / 100;
        energyDemandMinus += campaignEffectiveness;
        money -= 40;
        printm();
    }

    public void E_Cam2()
    {
        EnergyCam3.gameObject.SetActive(true);
        EnergyCam2.interactable = false;
        campaignEffectiveness1 = rnd.Next(70, 131);
        campaignEffectiveness = campaignEffectiveness1 / 100;
        energyDemandMinus += campaignEffectiveness;
        money -= 40;
        printm();
    }

    public void E_Cam3()
    {
        EnergyCam3.interactable = false;
        campaignEffectiveness1 = rnd.Next(30, 71);
        campaignEffectiveness = campaignEffectiveness1 / 100;
        energyDemandMinus += campaignEffectiveness;
        money -= 40;
        printm();
    }  
    public void edu1()
    {
        Edu2.gameObject.SetActive(true);
        Edu1.interactable = false;
        educationReduce = 7.5;
        educationDay = day;
        money -= 5;
        printm();
    }

    public void edu2()
    {
        Edu2.interactable = false;
        educationReduce = 22.5;
        educationDay = day;
        money -= 10;
        printm();
    }
    public void Wa1()
    {
        Warning2.gameObject.SetActive(true);
        Warning1.interactable = false;
        money -= 20;
        floodDeathReduce = 20;
        warningSystemDay = day;
        printm();
    }

    public void Wa2()
    {
        Warning3.gameObject.SetActive(true);
        Warning2.interactable = false;
        money -= 30;
        floodDeathReduce = 40;
        warningSystemDay = day;
        printm();
    }

    public void Wa3()
    {
        Warning3.interactable = false;
        money -= 40;
        floodDeathReduce = 50;
        warningSystemDay = day;
        printm();
    }  
    public void Tfw1()
    {
        Tempfw2.gameObject.SetActive(true);
        Tempfw1.interactable = false;
        money -= 10;
        floodDeathReduce1 = 10;
        floodWallDay = day;
        printm();
    }

    public void Tfw2()
    {
        Tempfw3.gameObject.SetActive(true);
        Tempfw2.interactable = false;
        floodDeathReduce1 = 20;
        floodWallDay = day;
        money -= 20;
        printm();

    }

    public void Tfw3()
    {
        Tempfw3.interactable = false;
        floodDeathReduce1 = 30;
        floodWallDay = day;
        money -= 30;
        printm();
    } 
    public void Cs1()
    {
        Seeding2.gameObject.SetActive(true);
        Seeding1.interactable = false;
        money -= 5;
        waterPlusDuringDrought += 1;
        printm();
    }

    public void Cs2()
    {
        Seeding3.gameObject.SetActive(true);
        Seeding2.interactable = false;
        money -= 10;
        waterPlusDuringDrought += 2;
        printm();
    }

    public void Cs3()
    {
        Seeding3.interactable = false;
        money -= 20;
        waterPlusDuringDrought += 3;
        printm();
    } 
    public void EV1()
    {
        arbitary = rnd.Next(10, 21);
        popularity += arbitary / 100;
        Ev2.gameObject.SetActive(true);
        Ev1.interactable = false;
        money -= 30;
        ecoFriendlySubsidies += 1;
        printm();
    }

    public void EV2()
    {
        arbitary = rnd.Next(10, 21);
        popularity += arbitary / 100;
        Ev3.gameObject.SetActive(true);
        Ev2.interactable = false;
        money -= 45;
        ecoFriendlySubsidies += 1;
        printm();
    }
    public void EV3()
    {
        arbitary = rnd.Next(10, 21);
        popularity += arbitary / 100;
        Ev3.interactable = false;
        money -= 60;
        ecoFriendlySubsidies += 1;
        EvSwitch = "on";
        printm();
    }
    public void EA1()
    {
        arbitary = rnd.Next(21, 41);
        popularity += arbitary / 100;
        Ea2.gameObject.SetActive(true);
        Ea1.interactable = false;
        money -= 15;
        ecoFriendlySubsidies += 1;
        printm();
    }

    public void EA2()
    {
        arbitary = rnd.Next(21, 41);
        popularity += arbitary / 100;
        Ea3.gameObject.SetActive(true);
        Ea2.interactable = false;
        money -= 25;
        ecoFriendlySubsidies += 1;
        printm();
    }

    public void EA3()
    {
        arbitary = rnd.Next(21, 41);
        popularity += arbitary / 100;
        Ea3.interactable = false;
        money -= 35;
        ecoFriendlySubsidies += 1;
        printm();
    }
    public void checkSolar()
    {

	if (solar_level == 2){
	    solar1p.interactable = false;
	    solar2p.interactable = false;
	    solar2p.gameObject.SetActive(true);
	    solar3.gameObject.SetActive(true);
	}
	if (solar_level == 3){
	    solar1p.interactable = false;
	    solar2p.interactable = false;
	    solar3.interactable = false;
	    solar2p.gameObject.SetActive(true);
	    solar3.gameObject.SetActive(true);
	}
    }

    public void reset()
    {
        VertFarm2.gameObject.SetActive(false);
        VertFarm3.gameObject.SetActive(false);
        VertFarm4.gameObject.SetActive(false);
        VertFarm5.gameObject.SetActive(false);
        fishFarm2.gameObject.SetActive(false);
        wimport4.gameObject.SetActive(false);
        fuel6.gameObject.SetActive(false);
        solar2.gameObject.SetActive(false);
        fration2.gameObject.SetActive(false);
        fration3.gameObject.SetActive(false);
        wration2.gameObject.SetActive(false);
        wration3.gameObject.SetActive(false);
        ch4.gameObject.SetActive(false);
        fw4.gameObject.SetActive(false);
        VertFarm1.interactable = true;
        VertFarm2.interactable = true;
        VertFarm3.interactable = true;
        VertFarm4.interactable = true;
        VertFarm5.interactable = true;
        fishFarm1.interactable = true;
        fishFarm2.interactable = true;
        nwater5.interactable = true;
        desal4.interactable = true;
        wimport3.interactable = true;
        wimport4.interactable = true;
        fuel5.interactable = true;
        fuel6.interactable = true;
        solar1.interactable = true;
        solar2.interactable = true;
        fration1.interactable = true;
        fration2.interactable = true;
        fration3.interactable = true;
        wration1.interactable = true;
        wration2.interactable = true;
        wration3.interactable = true;
        ch3.interactable = true;
        ch4.interactable = true;
        fw3.interactable = true;
        fw4.interactable = true;
        money = 650;
	    printm();
    }
    public void Upgrade()
    {
        if (money >= Int16.Parse(descs[b][2]))
        {
            if (b == "VerticalFarms(I)")
            {
                Vert_Farm1();
            }
            if (b == "VerticalFarms(II)")
            {
                Vert_Farm2();
            }
            if (b == "VerticalFarms(III)")
            {
                Vert_Farm3();
            }
            if (b == "VerticalFarms(IV)")
            {
                Vert_Farm4();
            }
            if (b == "VerticalFarms(V)")
            {
                Vert_Farm5();
            }
            if (b == "FishFarms(I)")
            {
                fish_Farm1();
            }
            if (b == "FishFarms(II)")
            {
                fish_Farm2();
            }
            if (b == "FoodRations(I)")
            {
                f_ration1();
            }
            if (b == "FoodRations(II)")
            {
                f_ration2();
            }
            if (b == "FoodRations(III)")
            {
                f_ration3();
            }
            if (b == "WaterRations(I)")
            {
                w_ration1();
            }
            if (b == "WaterRations(II)")
            {
                w_ration2();
            }
            if (b == "WaterRations(III)")
            {
                w_ration3();
            }
            if (b == "RecycledWater(V)")
            {
                n_water5();
            }
            if (b == "Desalination(IV)")
            {
                desal_4();
            }
            if (b == "WaterImports(III)")
            {
                w_import3();
            }
            if (b == "WaterImports(IV)")
            {
                w_import4();
            }
            if (b == "FossilFuels(V)")
            {
                fuel_5();
            }
            if (b == "FossilFuels(VI)")
            {
                fuel_6();
            }
            if (b == "SolarEnergy(I)")
            {
                solar_1();
            }
            if (b == "SolarEnergy(II)")
            {
                solar_2();
            }
            if (b == "Channels(III)")
            {
                CH3();
            }
            if (b == "Channels(IV)")
            {
                CH4();
            }
            if (b == "FloodWalls(III)")
            {
                F_wall3();
            }
            if (b == "FloodWalls(IV)")
            {
                F_wall4();
            }
            if (b == "FoodStorage(I)")
            {
                Food_Stor1();
            }
            if (b == "FoodStorage(II)")
            {
                Food_Stor2();
            }
            if (b == "FoodStorage(III)")
            {
                Food_Stor3();
            }
            if (b == "FoodCampaigns(I)" & foodCampaignSwitch != "on")
            {
                Food_Cam1();
            }
            if (b == "FoodCampaigns(II)" & foodCampaignSwitch != "on")
            {
                Food_Cam2();
            }
            if (b == "FoodCampaigns(III)" & foodCampaignSwitch != "on")
            {
                Food_Cam3();
            }
            if (b == "LocalFarms(I)")
            {
                L_Farm1();
            }
            if (b == "LocalFarms(II)")
            {
                L_Farm2();
            }
            if (b == "LocalFarms(III)")
            {
                L_Farm3();
            }
            if (b == "WaterCampaigns(I)")
            {
                W_Cam1();
            }
            if (b == "WaterCampaigns(II)")
            {
                W_Cam2();
            }
            if (b == "WaterCampaigns(III)")
            {
                W_Cam3();
            }
            if (b == "WaterStorage(I)")
            {
                W_Stor1();
            }
            if (b == "WaterStorage(II)")
            {
                W_Stor2();
            }
            if (b == "WaterStorage(III)")
            {
                W_Stor3();
            }
            if (b == "EnergyCampaigns(I)")
            {
                E_Cam1();
            }
            if (b == "EnergyCampaigns(II)")
            {
                E_Cam2();
            }
            if (b == "EnergyCampaigns(III)")
            {
                E_Cam3();
            }
            if (b == "SolarPanels(I)")
            {
                solar_1p();
            }
            if (b == "SolarPanels(II)")
            {
                solar_2p();
            }
            if (b == "SolarPanels(III)")
            {
                solar_3();
            }
            if (b == "Education(I)")
            {
                edu1();
            }
            if (b == "Education(II)")
            {
                edu2();
            }
            if (b == "TemporaryFloodWalls(I)")
            {
                Tfw1();
            }
            if (b == "TemporaryFloodWalls(II)")
            {
                Tfw2();
            }
	        if (b == "TemporaryFloodWalls(III)")
            {
                Tfw3();
            }
            if (b == "CloudSeeding(I)")
            {
                Cs1();
            }
            if (b == "CloudSeeding(II)")
            {
                Cs2();
            }
            if (b == "CloudSeeding(III)")
            {
                Cs3();
            }
            if (b == "WarningSystems(I)")
            {
                Wa1();
            }
            if (b == "WarningSystems(II)")
            {
                Wa2();
            }
            if (b == "WarningSystems(III)")
            {
                Wa3();
            }
            if (b == "SubsidiseEVs(I)")
            {
                EV1();
            }
            if (b == "SubsidiseEVs(II)")
            {
                EV2();
            }
            if (b == "SubsidiseEVs(III)")
            {
                EV3();
            }
            if (b == "Eco-FriendlyAppliances(I)")
            {
                EA1();
            }
            if (b == "Eco-FriendlyAppliances(II)")
            {
                EA2();
            }
            if (b == "Eco-FriendlyAppliances(III)")
            {
                EA3();
            }
            closeInfo();
        }

    }

    public void closeEvent()
    {
        events1.SetActive(false);
        Time.timeScale = times;
	    task.interactable = true;
    }
    public void closeTask()
    {
        taskpanel.SetActive(false);
        taskDescription.Clear();
        if (!events1.activeSelf & !choice.activeSelf) {
	      Time.timeScale = times;
	    }
        task.interactable = true;
    }
    public void openTask()
    {        
        Time.timeScale = 0;       
        tasktitle.text = "Tasks";
        taskpanel.SetActive(true);
        if (randomTask1 == 0)
        {
            taskDescription.Append("Click on a pop-up at x2 speed or higher " + task1Status + "\n");
        }
        else if (randomTask1 == 1)
        {
            taskDescription.Append("Prevent grass from turning yellow during drought periods " + task2Status + "\n");
        }
        else 
        {
            taskDescription.Append("Have at least a 100 development points remaining at the end of the game\n");
        }

        if (randomTask2 == 3)
        {
            taskDescription.Append("Get Tesla to open a regional headquarters in Singapore " + task4Status + "\n");
        }
        else if (randomTask2 == 4)
        {
            taskDescription.Append("Adopt 3 environmentally friendly policies (" + ecoFriendlyInitiative + "/3)\n");
        }
        else
        {
            taskDescription.Append("Subsidise eco-friendly products 5 times (" + ecoFriendlySubsidies + "/5)\n");
        }        
        tasktxt.text = taskDescription + "Have floods cause less than " + (floodRequirement[difficulty - 1] + 1) + " deaths (" + totalFloodDeaths + ")\nHave heat waves cause less than " + (heatWaveRequirement[difficulty - 1] + 1) + " deaths (" + totalHeatWaveDeaths + ")";
        task.interactable = false;
    }
    public void openEvent()
    {
        Time.timeScale = 0;
        events1.SetActive(true);        
	    task.interactable = false;
    }
    public void closeOpt()
    {
        choice.SetActive(false);
        Time.timeScale = times;
	    task.interactable = true;
        Time.timeScale = times;
    }
    public void options(Button btn)
    {
        opt = btn.name;
        closeOpt();
    }
  
    double popularity = 58;
    int day = 0;





    public IEnumerator gamePlay()
    {
        string disaster_name = " ";
        string status = " ";
        string event_name = " ";
        string information_name = " ";
        string title = " ";
        string description = " ";
        string starvationSwitch1 = " ";
        string starvationSwitch2 = " ";
        string starvationSwitch3 = " ";
        string starvationSwitch4 = " ";
        int flood_day = 0;
        int flood_day1 = 0;
        int heatWave_day = 0;
        int heatWave_day1 = 0;
        int dead = 0;
        int cost = 0;
        int tasksCompleted = 0;
        double foodSufficiency = 100;
        double waterSufficiency = 100;
        double energySufficiency = 100;
        List<int> dayList = new List<int>();
        List<int> disasterList = new List<int>();
        List<int> disasterList1 = new List<int>();
        int moneyPlus = rnd.Next(3, 6);
        int newsLength = 0;
        int daysWithoutFood = 0;
        int daysWithoutFoodX = 3;
        string endDescription = "";
        string cityName = "";

        //creates a list which genereates the numbers 20, 30, 40 all the way to 1460
        int dayListX = 20;
        while (dayListX < 1470)
        {
            dayList.Add(dayListX);
            dayListX += 10;
        }

        int disasterListX = 0;
        while (disasterListX < 4)
        {
            disasterList.Add(disasterListX);
            disasterListX += 1;
        }

        int disasterListY = 0;
        while (disasterListY < 2)
        {
            disasterList1.Add(disasterListY);
            disasterListY += 1;
        }


              
        var disaster = new Dictionary<int, string>();
        var events = new Dictionary<int, string>();
        var ongoingEvents = new List<string>();
        var information = new Dictionary<int, string>();
        information.Add(1500, "hi");
        var finder = information.First(kvp => kvp.Value == "hi");

        arbitary = rnd.Next(2100, 2501);
        popularity += arbitary / 1000;

        printm();
        printothers();

        if (additionalFoodProduced >= 10)
        {
            popularity += (additionalFoodProduced - 10) * 0.1;
            information.Add(10, "foodCommendation");
            dayList.Remove(10);
        }
        if (additionalWaterProduced >= 10)
        {
            popularity += (additionalWaterProduced - 10) * 0.025;
            information.Add(20, "waterCommendation");
            dayList.Remove(20);
        }
        if (solar_level > 1)
        {
            popularity += (solar_level - 1) * 0.25;
            information.Add(30, "solarCommendation");
            dayList.Remove(30);
        }

        //daily consumption of 5.8 thousand tonnes
        double food = 100;

        //daily consumption of 430 million gallons
        double water = 100;
        double energy = 100;


        int flood_duration = 0;
        double flood_deaths = 0;
        double flood_deaths1 = 0;
        int heatWave_duration = 0;
        int heatWave_deaths = 0;
        int heatWave_deaths1 = 0;
        int chance = 0;
        int chance1 = 0;
        int chance2 = 0;
        int chance3 = 0;
        int chance4 = 0;
        int supportNeedyFamiliesX = 160;
        string worldCupSwitch1 = " ";
        string worldCupSwitch2 = " ";
        string worldCupSwitch3 = " ";
        string energySwitch = " ";
        string teslaSwitch = " ";
        int sportsX = 0;
        string sportsY = " ";
            
        List<string> anytimeEvents = new List<string>(4);
        anytimeEvents.Add("plasticTax");
        anytimeEvents.Add("recyclePlastics");
        anytimeEvents.Add("recycleElectronics");
        anytimeEvents.Add("gotTalentShow");

        List<string> cityList = new List<string>(44) { "Paya Lebar", "Sembawang", "Bendemeer", "Tampines", "Bukit Panjang", "Bedok", "Choa Chu Kang", "Hougang", "Tanjong Pagar", "Sengkang", "Changi", "Boon Keng", "Bugis", "Katong", "Bukit Timah", "Bukit Gombak", "Seletar", "Pasir Ris", "Novena", "Yishun", "Geylang", "Bukit Batok", "Aljunied", "Balestier", "Boon Lay", "Holland Village", "Marine Parade", "Bishan", "Bukit Merah", "Punggol", "Eunos", "Sembawang", "Clementi", "Jurong", "Queenstown", "Serangoon", "Lavender", "Commonwealth", "Ang Mo Kio", "Chinatown", "Little India", "Woodlands", "Orchard", "Toa Payoh" };
        List<string> countryList1 = new List<string>(13) { "South Korea", "Australia", "Iran", "Lebanon", "Syria", "Oman", "China", "Japan", "Malaysia", "Thailand", "Indonesia", "Vietnam", "Saudi Arabia" };
        List<string> countryList2 = new List<string>(13) { "Nigeria", "Denmark", "Iceland", "Sweden", "Slovenia", "Finland", "Scotland", "Romania", "Slovakia", "Bulgaria", "Ukraine", "Czech Republic", "Norway" };
        List<string> countryList3 = new List<string>(12) { "Belgium", "Switzerland", "France", "England", "Portugal", "Russia", "Spain", "United States", "Brazil", "Uraguay", "Chile", "Argentina", "Wales" };
        List<string> playerList1 = new List<string>(4) { "Erling Haaland", "Jude Bellingham", "João Félix", "Alphonso Davies"};
        List<string> playerList2 = new List<string>(9) { "Luka Doncic", "Zion Williamson", "Jayson Tatum", "Devin Booker", "Trae Young", "De'Aaron Fox", "Ja Morant", "LaMelo Ball", "Lonzo Ball"};
        List<string> teamList1 = new List<string>(9) { "Mavericks", "Pelicans", "Celtics", "Suns", "Hawks", "Kings", "Grizzlies", "Hornets", "Bulls" };

        List<string> jokesAndTips = new List<string>(23);
        jokesAndTips.Add("Primary 6 students consoles his distraught parents after he gets an AL5 for the PSLE");
        jokesAndTips.Add("Report: Women and children are evacuated first so that the rest can think of a solution in silence");
        jokesAndTips.Add("Lazy student claims his teacher's criticism of him is unfair as 'he didn't do anything'");
        jokesAndTips.Add("Tom Holland, now in his mid-thirties, to finally stop being cast as a hormonal teenager");
        jokesAndTips.Add("Local cartoonist arrested for 'spreading misinformation’. Details are sketchy.");
        jokesAndTips.Add("Restaurant named ‘Karma’ opened in the Jewel. It has no menu as customers are served what they deserve.");
        jokesAndTips.Add("Singaporean student refuses to trust atoms; claims that ‘they make up everything’");
        jokesAndTips.Add("School of the Arts Singapore (SOTA) held an art contest for Singaporean students over the weekend. It ended in a draw.");
        jokesAndTips.Add("Restaurant dedicated to selling snails opens in Sengkang. Food tasters say it is a break from fast food.");
        jokesAndTips.Add("Fast and Furious 15 is released in cinemas; fans gush over Vin Diesel’s new hairstyle");
        jokesAndTips.Add("Singaporean intern fired from Pharmaceutical store after placing medication for back pain at the bottom shelf");
        jokesAndTips.Add("Many celebrities fatally injured in bomb explosion; netizens mourn the loss of their razor sharp political advice");
        jokesAndTips.Add("18 Chefs opens its first restaurant on the moon. Critics say it has great food and service but no atmosphere.");
        jokesAndTips.Add("Report: In a capitalist society, men oppress men. In a communist society, it's the other way round.");
        jokesAndTips.Add("Singaporean man goes viral after going door-to-door to sell doors");
        jokesAndTips.Add("Judge criticises pai kia who vandalises HDB multi-story carpark; says it is wrong on 'so many levels'");
        jokesAndTips.Add("Report: Exaggerations went up by one million percent last year");
        jokesAndTips.Add("Singaporean girl upset with her NS boyfriend after she asks him what his rank is and he keeps saying 'It's private'");
        jokesAndTips.Add("Singaporean woman goes home after her boss tells her to 'have a good day'");
        jokesAndTips.Add("A wise Singaporean doctor once wrote: [Illegible]");
        jokesAndTips.Add("Singaporean student enters National Library and orders a burger. After the librarian says, 'This is a library!', he apologizes and whispers, 'I'd like a hamburger, please'.");
        jokesAndTips.Add("Petition to rename soldier ants 'combatants' goes viral");
        jokesAndTips.Add("Singaporean man complains that his wife has a weird habit of starting conversations with 'Are you even listening to me?'");


        List<string> currentAffairs = new List<string>(44);
        currentAffairs.Add("Thousands of mega-scale carbon capture projects commissioned worldwide in a bid to reduce atmospheric carbon dioxide");
        currentAffairs.Add("G7 countries pledge to donate 75 billion USD to tree-planting projects in a bid to reduce carbon dioxide emissions");
        currentAffairs.Add("More and more countries turning to nuclear energy in a bid to cut down carbon dioxide emissions");
        x = rnd.Next(5, 5 + difficulty * 3);
        description = "Report: Global sea level rose by " + x + " mm from 2020 - 2030";
        currentAffairs.Add(description);
        currentAffairs.Add("Increase in rainfall causing a spike in mosquito populations locally");
        currentAffairs.Add("Report: For every degree in increase of temperature, time taken for Aedes mosquitoes to develop from egg to adult decreases by about 5%");
        currentAffairs.Add("Report: For every degree increase in temperature, 7% of the world’s population will see a 20 % decrease in water resources available to them");
        currentAffairs.Add("Report: Ocean acidification caused by carbon dioxide emissions increasing dead spots along coastal areas worldwide");
        currentAffairs.Add("Report: Rise in global temperatures threatening the survival of 60% of coral reefs worldwide");
        description = "Arctic sea ice summertime minimum " + x + " square miles below the 1981 - 2010 average; Scientists attribute this to global warming";
        currentAffairs.Add(description);
        currentAffairs.Add("Report: Greenland Ice Sheet can no longer be maintained due to an increase in average temperature");
        currentAffairs.Add("Report: Extra warmth and water due to climate change likely to make tropical cyclones stronger and last longer");
        x = rnd.Next(6, 6 + difficulty * 2);
        description = "Abnormal weather patterns have resulted in severe water reductions for " + x + "% of the world population";
        currentAffairs.Add(description);
        currentAffairs.Add("Multiple countries around the world dangerously close to reaching “Day Zero” - the term for the moment when a city's taps run dry");
        currentAffairs.Add("Report: Melting of Arctic sea ice which used to act as a reflective surface accelerating global warming");
        x = rnd.Next(6, 6 + difficulty * 3);
        description = "Report: " + x + "% of Amazon forest damaged by drought; Scientists fear it will have a devastating impact on wildlife ecosystems in the forest";
        currentAffairs.Add(description);
        currentAffairs.Add("Acidification, changes in temperature and a decrease in oxygen concentrations of ocean water prompting mass migrations of marine life");
        currentAffairs.Add("Compound heatwaves in countries near the equator have caused heat-related deaths to increase by two-fold in the past 10 years");
        currentAffairs.Add("Report: Nearly a million species of animals and plants are facing extinction due to human activities and climate change");
        x = rnd.Next(5, 5 + difficulty * 5);
        description = "Fishermen in the tropics reporting declines of " + x + "% in mass of fish caught as compared to 2020";
        currentAffairs.Add(description);
        x = rnd.Next(15, 15 + difficulty * 5);
        description = "Farmers in developing countries reporting crop-yield declines of " + x + "% as compared to 2020";
        currentAffairs.Add(description);
        x = rnd.Next(6, 6 + difficulty * 4);
        description = "Freshwater availability in the Mediterranean down by " + x + "% as compared to 2020";
        currentAffairs.Add(description);
        x = rnd.Next(6, 6 + difficulty * 3);
        description = "Report: Wheat production worldwide down by " + x + "% as compared to 2020";
        currentAffairs.Add(description);
        x = rnd.Next(3, 3 + difficulty * 2);
        description = "Report: Maize production worldwide down by " + x + "% as compared to 2020";
        currentAffairs.Add(description);
        x = rnd.Next(2, 2 + difficulty);
        description = "Report: Rice production worldwide up by " + x + "% as compared to 2020";
        currentAffairs.Add(description); //25 climate change related news headlines

        currentAffairs.Add("First group of humans land on mars");
        x = rnd.Next(44);
        cityName = cityList[x];
        currentAffairs.Add("Robotic dog wrecks havoc in " + cityName + " before policemen finally destroy it with their own robotic dog");
        currentAffairs.Add("Flying cars a new normal. As they use only hydrogen gas for fuel, they are 'cleaner' than conventional cars.");
        currentAffairs.Add("Razer produces first commercially available quantum gaming laptop");
        currentAffairs.Add("Robotic nanobots approved for use in critically ill Singaporeans");
        currentAffairs.Add("The moon now the most popular honeymoon destination for newly-wed Singaporeans");
        currentAffairs.Add("Designer babies now possible for ultra-wealthy Singaporeans");
        currentAffairs.Add("Due to new breakthroughs in fusion energy, scientists predict that fusion power plants could be built in a few years time");
        currentAffairs.Add("Bacteriophages proven extremely effective as a treatment for antibiotic-resistant bacterial infections");
        currentAffairs.Add("Glaciers with ancient viruses deposited in them melt rapidly; scientists fear the worse");
        currentAffairs.Add("New bioweapons capable of targeting specific ethnicities developed in multiple countries");
        currentAffairs.Add("Disarmament efforts proven ineffective due to an increase in the number of countries having access to nuclear fission energy");
        currentAffairs.Add("Virtual reality headsets rapidly replacing smartphones");
        currentAffairs.Add("15% of humans now wear clothing connected to the Internet");
        currentAffairs.Add("Report: 50% of all office workers now work from home");
        currentAffairs.Add("4D printers now available to Singaporeans consumers");
        currentAffairs.Add("First batch of metal ores sent back to Earth from the asteroid belt");
        currentAffairs.Add("Virtual world created by Fakebook; experts predict that over 3 billion people will visit it within the next 2 years");
        currentAffairs.Add("Tesla creates space car"); //19 tech related news headlines


        List<string> sportsUpdates = new List<string>(37);
        x = rnd.Next(13);
        cityName = countryList1[x];
        sportsUpdates.Add("Singapore's football team beats " + cityName + " and qualify for the 64-team 2030 World Cup; Singaporeans elated");
        sportsUpdates.Add("Singapore's football team beats 10-man " + cityName + " 3-2 to qualify for the 64-team 2030 World Cup; Singaporeans elated");
        x = rnd.Next(3, 7);
        sportsUpdates.Add("Singapore's football team humbled " + x + "-0 by " + cityName + " as their 2030 World Cup bid crashes and burns");
        sportsUpdates.Add("Singapore's football team beaten " + x + "-2 by " + cityName + " as their losing streak extends to " + x + " and they fail to qualify for the World Cup once again");
        x = rnd.Next(13);
        cityName = countryList2[x];
        sportsUpdates.Add("Singapore's football team brought back to earth after " + cityName + " trashes them 3-0 to knock them out of the 2030 World Cup");
        sportsUpdates.Add("Singapore's football team loses 3 straight games; is one the first country to get eliminated in the 2030 World Cup");
        sportsUpdates.Add("Singapore's football team plays some great team football to defy expectations and qualify for the 2030 World Cup round of 32; Singaporeans overjoyed");
        sportsUpdates.Add("Singapore's football team qualifies for 2030 World Cup round of 32 with a game to spare; success credited to head coach Fandi Ahmad's shrewd tactics");
        sportsUpdates.Add("90th minute Irfan Fandi winner helps Singapore's football team beat " + cityName + " to qualify for the 2030 World Cup round of 16; Irfan now the most popular baby name in Singapore");
        sportsUpdates.Add("Despite a gritty performance, Singapore's football team loses to " + cityName + " in the 2030 World Cup round of 32");
        x = rnd.Next(12);
        cityName = countryList3[x];
        sportsUpdates.Add("Despite playing well, Singapore's football team loses to " + cityName + " in the 2030 World Cup round of 16; Singaporeans still very proud of their football team");



        //mainstream sports updates
        sportsUpdates.Add("Arsenal finishes in bottom half of English Premier League table for 2nd year in a row; Arteta finally gets the sack");
        sportsUpdates.Add("Phil Foden hat-trick helps Manchester City win their last game of the season and win the English Premier League");
        sportsUpdates.Add("Spurs win FA cup as they finally break their trophy drought");
        sportsUpdates.Add("Liverpool captain Trent Alexander Arnold scores 90th minute free kick to help Liverpool beat Newcastle United in Champions League Final; Klopp enters the GOAT conversation");        
        sportsUpdates.Add("Christian Pulisic and Mason Mount carry Chelsea to Premier League Title");
        sportsUpdates.Add("Pedri & Ansu Fati carry Barcelona to La Liga title in the absence of injured veteran winger Ousmane Dembele");        
        sportsUpdates.Add("United finish 7th in the table for 3rd time in a row; Wayne Rooney to take over as manager, Cristiano Ronaldo to join coaching staff as well");
        
        sportsUpdates.Add("Conor McGregor buys over Manchester United");
        sportsUpdates.Add("Mason Greenwood and Jadon Sancho carry Manchester United to Premier League Title");

        sportsUpdates.Add("Thierry Henry to take over as Arsenal manager");
        sportsUpdates.Add("Bayuko Saka and Smith Rowe carry Arsenal to Premier League title");

        sportsUpdates.Add("40 year-old Harry Kane cries tears of joy after winning his first trophy with Spurs");

        sportsUpdates.Add("'We got sick of winning' comments Newcastle United manager after his team loses to Liverpool in Champions League Final");

        x = rnd.Next(4);
        sportsUpdates.Add("Scientists build robots capable of challenging professional football players; 'Robots vs Humans' match to take place soon");
        sportsUpdates.Add(playerList1[x] + " makes robots look like unintelligent pieces of metal as he notches 10 nutmegs and 4 goals");
        sportsUpdates.Add(playerList1[x] + " makes robots look like six-year old kids; scores 2 hat tricks before being subbed off at half-time");
        sportsUpdates.Add("Team Robots scores an early goal, parks the bus for the remaining 89 minutes to win the 'Robots vs Humans' football match");

        x = rnd.Next(9);
        sportsUpdates.Add(teamList1[x] + " win the NBA championship as " + playerList2[x] + " is named Finals MVP");
        sportsUpdates.Add("Scientists build robots capable of challenging professional basketball players; 'Robots vs Humans' match to take place soon");
        x = rnd.Next(9);
        sportsUpdates.Add(playerList2[x] + " makes 'Team Robots' look like six-year olds in the bodies of 18 year-olds; scores 69 points before being taken off at half-time");
        sportsUpdates.Add("Luka Doncic puts robots on skates as he dominates in the 'Robots vs Humans' match; is later charged for murdering every robot he played against");
        sportsUpdates.Add("Trae Young makes 40 free throws as his 70 point performance helps gives 'Team Humans' a big win over 'Team Robots'");
        sportsUpdates.Add("'Team Robots' win as nobody on 'Team Humans' can stop their 8 feet center with a vertical of 50 inches");
        sportsUpdates.Add("'So what? They've got less personality than Kawhi Leonard!' chants fans after the 'Team Humans' loss");



        if (difficulty == 1)
        {
            chance = rnd.Next(4);
            int flood_year = disasterList[chance];
            disasterList.RemoveAt(chance);
            flood_day = rnd.Next(32, 35) * 10 + flood_year * 360;
            flood_duration = rnd.Next(3, 5) * 10;
            int flood_end = flood_day + flood_duration;
            double flood_height = difficulty - (0.20 * channels);
            double flood_deaths_double = Math.Pow(2, flood_height) * (flood_height + 12) + rnd.Next((difficulty + 1) * (difficulty + 1));
            flood_deaths = Convert.ToInt32(flood_deaths_double);
            disaster.Add(flood_day, "flood");
            disaster.Add(flood_end, "floodEnd");
            dayList.Remove(flood_day);
            dayList.Remove(flood_end);

            chance = rnd.Next(3);
            int heatWave_year = disasterList[chance];
            disasterList.RemoveAt(chance);
            heatWave_day = rnd.Next(13, 17) * 10 + heatWave_year * 360;
            heatWave_duration = rnd.Next(3, 5) * 10;
            int heatWave_end = heatWave_day + heatWave_duration;
            double heatWave_height = Math.Pow(2, difficulty + 1);
            double heatWave_deaths_double = heatWave_height * heatWave_height + rnd.Next((difficulty + 1) * (difficulty + 1));
            heatWave_deaths = Convert.ToInt32(heatWave_deaths_double);
            events.Add(heatWave_day + 10, "heatWaveCloseConstruction");
            events.Add(heatWave_day + 20, "heatWaveCloseFacilities");
            disaster.Add(heatWave_day, "heatWave");
            disaster.Add(heatWave_end, "heatWaveEnd");
            dayList.Remove(heatWave_day);
            dayList.Remove(heatWave_day + 10);
            dayList.Remove(heatWave_day + 20);
            dayList.Remove(heatWave_end);

            chance = rnd.Next(2);
            int drought_year = disasterList[chance];
            disasterList.RemoveAt(chance);
            int drought_day = rnd.Next(8, 12) * 10 + drought_year * 360;
            int drought_end = drought_day + rnd.Next(4, 6) * 10;
            disaster.Add(drought_day, "drought");
            disaster.Add(drought_end, "droughtEnd");
            dayList.Remove(drought_day);
            dayList.Remove(drought_end);

            flood_year = disasterList[0];
            flood_day1 = rnd.Next(32, 35) * 10 + flood_year * 360;
            int flood_duration1 = rnd.Next(3, 5) * 10;
            int flood_end1 = flood_day1 + flood_duration1;
            flood_height = difficulty - (0.20 * channels);
            flood_deaths_double = Math.Pow(2, flood_height) * (flood_height + 12) + rnd.Next((difficulty + 1) * (difficulty + 1));
            flood_deaths1 = Convert.ToInt32(flood_deaths_double);
            disaster.Add(flood_day1, "flood1");
            disaster.Add(flood_end1, "floodEnd1");
            dayList.Remove(flood_day1);
            dayList.Remove(flood_end1);

            int haze_year = rnd.Next(3);
            chance = rnd.Next(18, 23) + haze_year * 36;
            int haze_day = dayList[chance];
            int haze_event = dayList[chance + 1];
            int haze_end = dayList[chance + rnd.Next(4, 7)];
            disaster.Add(haze_day, "haze");
            events.Add(haze_event, "donateMasks");
            disaster.Add(haze_end, "hazeEnd");
            dayList.Remove(haze_day);
            dayList.Remove(haze_event);
            dayList.Remove(haze_end);
        }

        else if (difficulty == 2)
        {
            chance = rnd.Next(4);
            int flood_year = disasterList[chance];
            disasterList.RemoveAt(chance);
            flood_day = rnd.Next(30, 34) * 10 + flood_year * 360;
            flood_duration = rnd.Next(5, 7) * 10;
            int flood_end = flood_day + flood_duration;
            double flood_height = difficulty - (0.15 * channels);
            double flood_deaths_double = Math.Pow(2, flood_height) * (flood_height + 12) + rnd.Next((difficulty + 1) * (difficulty + 1));
            flood_deaths = Convert.ToInt32(flood_deaths_double);
            disaster.Add(flood_day, "flood");
            disaster.Add(flood_end, "floodEnd");
            dayList.Remove(flood_day);
            dayList.Remove(flood_end);

            chance = rnd.Next(3);
            int heatWave_year = disasterList[chance];
            disasterList.RemoveAt(chance);
            heatWave_day = rnd.Next(13, 17) * 10 + heatWave_year * 360;
            heatWave_duration = rnd.Next(5, 7) * 10;
            int heatWave_end = heatWave_day + heatWave_duration;
            double heatWave_height = Math.Pow(2, difficulty + 1);
            double heatWave_deaths_double = heatWave_height * heatWave_height + rnd.Next((difficulty + 1) * (difficulty + 1));
            heatWave_deaths = Convert.ToInt32(heatWave_deaths_double);
            events.Add(heatWave_day + 10, "heatWaveCloseConstruction");
            events.Add(heatWave_day + 20, "heatWaveCloseFacilities");
            disaster.Add(heatWave_day, "heatWave");
            disaster.Add(heatWave_end, "heatWaveEnd");
            dayList.Remove(heatWave_day);
            dayList.Remove(heatWave_day + 10);
            dayList.Remove(heatWave_day + 20);
            dayList.Remove(heatWave_end);

            chance = rnd.Next(2);
            int drought_year = disasterList[chance];
            disasterList.RemoveAt(chance);
            int drought_day = rnd.Next(8, 12) * 10 + drought_year * 360;
            int drought_end = drought_day + rnd.Next(8, 11) * 10;
            disaster.Add(drought_day, "drought");
            disaster.Add(drought_end, "droughtEnd");
            dayList.Remove(drought_day);
            dayList.Remove(drought_end);

            heatWave_day1 = drought_day + 10;
            heatWave_duration = rnd.Next(5, 7) * 10;
            int heatWave_end1 = heatWave_day1 + heatWave_duration;
            heatWave_height = Math.Pow(2, difficulty + 1);
            heatWave_deaths_double = heatWave_height * heatWave_height + rnd.Next((difficulty + 1) * (difficulty + 1));
            heatWave_deaths1 = Convert.ToInt32(heatWave_deaths_double);
            events.Add(heatWave_day1 + 10, "heatWaveCloseConstruction1");
            events.Add(heatWave_day1 + 20, "heatWaveCloseFacilities1");
            disaster.Add(heatWave_day1, "heatWave1");
            disaster.Add(heatWave_end1, "heatWaveEnd1");
            dayList.Remove(heatWave_day1);
            dayList.Remove(heatWave_day1 + 10);
            dayList.Remove(heatWave_day1 + 20);
            dayList.Remove(heatWave_end1);

            flood_year = disasterList[0];
            flood_day1 = rnd.Next(32, 36) * 10 + flood_year * 360;
            int flood_duration1 = rnd.Next(3, 5) * 10;
            int flood_end1 = flood_day1 + flood_duration1;
            flood_height = difficulty - (0.20 * channels);
            flood_deaths_double = Math.Pow(2, flood_height) * (flood_height + 12) + rnd.Next((difficulty + 1) * (difficulty + 1));
            flood_deaths1 = Convert.ToInt32(flood_deaths_double);
            disaster.Add(flood_day1, "flood1");
            disaster.Add(flood_end1, "floodEnd1");
            dayList.Remove(flood_day1);
            dayList.Remove(flood_end1);

            chance = rnd.Next(20, 51);
            int worldwar_day = dayList[chance];
            int worldwar_end = dayList[chance + rnd.Next(65, 80)];
            disaster.Add(worldwar_day, "worldwar");
            disaster.Add(worldwar_end, "worldwar_end");
            dayList.Remove(worldwar_day);
            dayList.Remove(worldwar_end);
        }

        else if (difficulty == 3)
        {
            chance = rnd.Next(4);
            int flood_year = disasterList[chance];
            disasterList.RemoveAt(chance);
            flood_day = rnd.Next(30, 34) * 10 + flood_year * 360;
            flood_duration = rnd.Next(5, 7) * 10;
            int flood_end = flood_day + flood_duration;
            double flood_height = difficulty - (0.15 * channels);
            double flood_deaths_double = Math.Pow(2, flood_height) * (flood_height + 12) + rnd.Next((difficulty + 1) * (difficulty + 1));
            flood_deaths = Convert.ToInt32(flood_deaths_double);
            disaster.Add(flood_day, "flood");
            disaster.Add(flood_end, "floodEnd");
            dayList.Remove(flood_day);
            dayList.Remove(flood_end);
            

            chance = rnd.Next(3);
            int heatWave_year = disasterList[chance];
            disasterList.RemoveAt(chance);
            heatWave_day = rnd.Next(13, 17) * 10 + heatWave_year * 360;
            heatWave_duration = rnd.Next(5, 7) * 10;
            int heatWave_end = heatWave_day + heatWave_duration;
            double heatWave_height = Math.Pow(2, difficulty + 1);
            double heatWave_deaths_double = heatWave_height * heatWave_height + rnd.Next((difficulty + 1) * (difficulty + 1));
            heatWave_deaths = Convert.ToInt32(heatWave_deaths_double);
            events.Add(heatWave_day + 10, "heatWaveCloseConstruction");
            events.Add(heatWave_day + 20, "heatWaveCloseFacilities");
            disaster.Add(heatWave_day, "heatWave");
            disaster.Add(heatWave_end, "heatWaveEnd");
            dayList.Remove(heatWave_day);
            dayList.Remove(heatWave_day + 10);
            dayList.Remove(heatWave_day + 20);
            dayList.Remove(heatWave_end);

            chance = rnd.Next(2);
            flood_year = disasterList[chance];
            disasterList.RemoveAt(chance);
            flood_day1 = rnd.Next(30, 34) * 10 + flood_year * 360;
            flood_duration = rnd.Next(5, 7) * 10;
            int flood_end1 = flood_day1 + flood_duration;
            flood_height = difficulty - (0.20 * channels);
            flood_deaths_double = Math.Pow(2, flood_height) * (flood_height + 12) + rnd.Next((difficulty + 1) * (difficulty + 1));
            flood_deaths1 = Convert.ToInt32(flood_deaths_double);
            disaster.Add(flood_day1, "flood1");
            disaster.Add(flood_end1, "floodEnd1");
            dayList.Remove(flood_day1);
            dayList.Remove(flood_end1);

            heatWave_year = disasterList[0];
            heatWave_day1 = rnd.Next(13, 17) * 10 + heatWave_year * 360;
            heatWave_duration = rnd.Next(5, 7) * 10;
            int heatWave_end1 = heatWave_day1 + heatWave_duration;
            heatWave_height = Math.Pow(2, difficulty + 1);
            heatWave_deaths_double = heatWave_height * heatWave_height + rnd.Next((difficulty + 1) * (difficulty + 1));
            heatWave_deaths1 = Convert.ToInt32(heatWave_deaths_double);
            events.Add(heatWave_day1 + 10, "heatWaveCloseConstruction1");
            events.Add(heatWave_day1 + 20, "heatWaveCloseFacilities1");
            disaster.Add(heatWave_day1, "heatWave1");
            disaster.Add(heatWave_end1, "heatWaveEnd1");
            dayList.Remove(heatWave_day1);
            dayList.Remove(heatWave_day1 + 10);
            dayList.Remove(heatWave_day1 + 20);
            dayList.Remove(heatWave_end1);

            int drought_year = rnd.Next(2);
            int drought_day = rnd.Next(10, 13) * 10 + drought_year * 360;
            int drought_end = drought_day + rnd.Next(13, 15) * 10;
            disaster.Add(drought_day, "drought");
            disaster.Add(drought_end, "droughtEnd");
            dayList.Remove(drought_day);
            dayList.Remove(drought_end);

            drought_year = rnd.Next(2, 4);
            int drought_day1 = rnd.Next(10, 13) * 10 + drought_year * 360;
            int drought_end1 = drought_day1 + rnd.Next(13, 15) * 10;
            disaster.Add(drought_day1, "drought1");
            disaster.Add(drought_end1, "droughtEnd1");
            dayList.Remove(drought_day1);
            dayList.Remove(drought_end1);

            chance = rnd.Next(20, 51);
            int worldwar_day = dayList[chance];
            int nuclearwar_day = dayList[chance + rnd.Next(12, 25)];
            disaster.Add(worldwar_day, "worldwar");
            disaster.Add(nuclearwar_day, "nuclearwar");
            dayList.Remove(worldwar_day);
            dayList.Remove(nuclearwar_day);
        }

        if (difficulty < 3)
        {
            chance = rnd.Next(2);
            chance1 = rnd.Next(16, 18) + disasterList1[chance] * 36;
            disasterList1.RemoveAt(chance);
        }
        else
        {
            chance1 = rnd.Next(16, 18);
        }
        int indiaDrought_day = dayList[chance1];
        chance2 = rnd.Next(8, 13);
        chance3 = chance1 + chance2;
        int indiaDrought_impact = dayList[chance3];
        chance = 18 + (difficulty - 1) * 18 * (difficulty - 1);
        if (difficulty > 2)
        {
            chance -= 18;
        }
        chance4 = chance1 + rnd.Next(chance - 5, chance + 6);
        int indiaDrought_end = dayList[chance4];
        int indiaDrought_impact_end = dayList[chance4 + chance2];

        disaster.Add(indiaDrought_day, "indiaDrought");
        disaster.Add(indiaDrought_impact, "indiaDroughtImpact");
        disaster.Add(indiaDrought_end, "indiaDroughtEnd");
        disaster.Add(indiaDrought_impact_end, "indiaDroughtImpactEnd");
        dayList.Remove(indiaDrought_day);
        dayList.Remove(indiaDrought_impact);
        dayList.Remove(indiaDrought_end);
        dayList.Remove(indiaDrought_impact_end);

        if (difficulty < 3)
        {
            chance1 = rnd.Next(16, 18) + disasterList1[0] * 36;
        }
        else
        {
            chance1 = rnd.Next(16, 18);
        }
        int chinaDrought_day = dayList[chance1];
        chance2 = rnd.Next(8, 13);
        chance3 = chance1 + chance2;
        int chinaDrought_impact = dayList[chance3];
        chance = 18 + (difficulty - 1) * 18 * (difficulty - 1);
        if (difficulty > 2)
        {
            chance -= 18;
        }
        chance4 = chance1 + rnd.Next(chance - 5, chance + 6);
        int chinaDrought_end = dayList[chance4];
        int chinaDrought_impact_end = dayList[chance4 + chance2];
        disaster.Add(chinaDrought_day, "chinaDrought");
        disaster.Add(chinaDrought_impact, "chinaDroughtImpact");
        disaster.Add(chinaDrought_end, "chinaDroughtEnd");
        disaster.Add(chinaDrought_impact_end, "chinaDroughtImpactEnd");
        dayList.Remove(chinaDrought_day);
        dayList.Remove(chinaDrought_impact);
        dayList.Remove(chinaDrought_end);
        dayList.Remove(chinaDrought_impact_end);

        if (difficulty < 3)
        {
            chance = rnd.Next(2);
        }
        else
        {
            chance = 0;
        }
        chance1 = rnd.Next(16, 18) + chance * 36;
        int malaysiaDrought_day = dayList[chance1];
        chance2 = rnd.Next(8, 13);
        chance3 = chance1 + chance2;
        int malaysiaDrought_impact = dayList[chance3];
        int malaysiaDrought_impact1 = dayList[chance3 - 7];
        chance = 18 + (difficulty - 1) * 18 * (difficulty - 1);
        if (difficulty > 2)
        {
            chance -= 18;
        }
        chance4 = chance1 + rnd.Next(chance - 5, chance + 6);
        int malaysiaDrought_end = dayList[chance4];
        int malaysiaDrought_end1 = dayList[chance4 + 1];
        int malaysiaDrought_impact_end = dayList[chance4 + chance2];
        disaster.Add(malaysiaDrought_day, "malaysiaDrought");
        disaster.Add(malaysiaDrought_impact, "malaysiaDroughtImpact");
        if (difficulty > 1)
        {
            disaster.Add(malaysiaDrought_impact1, "malaysiaDroughtImpact1");
            disaster.Add(malaysiaDrought_end1, "malaysiaDroughtEnd1");
        }
        disaster.Add(malaysiaDrought_end, "malaysiaDroughtEnd");
        disaster.Add(malaysiaDrought_impact_end, "malaysiaDroughtImpactEnd");
        dayList.Remove(malaysiaDrought_day);
        dayList.Remove(malaysiaDrought_impact);
        dayList.Remove(malaysiaDrought_end);
        dayList.Remove(malaysiaDrought_end1);
        dayList.Remove(malaysiaDrought_impact_end);
        dayList.Remove(malaysiaDrought_impact1);

        chance = rnd.Next(5, 16);
        int ricePlague_day = dayList[chance];
        chance1 = chance + rnd.Next(10, 15);
        int ricePlague_impact = dayList[chance1];
        chance2 = 36 + (difficulty - 1) * 18;
        chance3 = chance + rnd.Next(chance2 - 5, chance2 + 6);
        int ricePlague_end = dayList[chance3];
        int ricePlague_impact_end = dayList[chance3 + chance1 - chance];
        int regulatePricesDay = dayList[chance1 + rnd.Next(1, 4)];
        disaster.Add(ricePlague_day, "ricePlague");
        disaster.Add(ricePlague_impact, "ricePlagueImpact");
        disaster.Add(ricePlague_end, "ricePlagueEnd");
        disaster.Add(ricePlague_impact_end, "ricePlagueImpactEnd");
        events.Add(regulatePricesDay, "regulatePrices");
        dayList.Remove(ricePlague_day);
        dayList.Remove(ricePlague_impact);
        dayList.Remove(ricePlague_end);
        dayList.Remove(ricePlague_impact_end);
        dayList.Remove(regulatePricesDay);

        chance = rnd.Next(5, 16);
        int bananaPlague_day = dayList[chance];
        chance1 = chance + rnd.Next(6, 11);
        int bananaPlague_impact = dayList[chance1];
        chance2 = 36 + (difficulty - 1) * 18;
        chance3 = chance + rnd.Next(chance2 - 10, chance2 + 11);
        int bananaPlague_end = dayList[chance3];
        int bananaPlague_impact_end = dayList[chance3 + chance1 - chance];
        disaster.Add(bananaPlague_day, "bananaPlague");
        disaster.Add(bananaPlague_impact, "bananaPlagueImpact");
        disaster.Add(bananaPlague_end, "bananaPlagueEnd");
        disaster.Add(bananaPlague_impact_end, "bananaPlagueImpactEnd");
        dayList.Remove(bananaPlague_day);
        dayList.Remove(bananaPlague_impact);
        dayList.Remove(bananaPlague_end);
        dayList.Remove(bananaPlague_impact_end);

        chance = rnd.Next(5, 16);
        int massInsectExtinction_date = dayList[chance];
        int massInsectExtinction_impact_date = dayList[chance + rnd.Next(15, 26)];
        disaster.Add(massInsectExtinction_date, "massInsectExtinction");
        disaster.Add(massInsectExtinction_impact_date, "massInsectExtinction_impact");
        dayList.Remove(massInsectExtinction_date);
        dayList.Remove(massInsectExtinction_impact_date);

        chance = rnd.Next(5, 16);
        int temperatureIncrease_date = dayList[chance];
        disaster.Add(temperatureIncrease_date, "temperatureIncrease");
        dayList.Remove(temperatureIncrease_date);


        events.Add(dayList[chance], anytimeEvents[3]);
        dayList.RemoveAt(chance);        
        chance = rnd.Next(dayList.Count);
        if (randomTask2 == 4)
        {           
            events.Add(dayList[chance], anytimeEvents[0]);
            dayList.RemoveAt(chance);
            chance = rnd.Next(dayList.Count);
            events.Add(dayList[chance], anytimeEvents[1]);
            dayList.RemoveAt(chance);
            chance = rnd.Next(dayList.Count);
            events.Add(dayList[chance], anytimeEvents[2]);
            dayList.RemoveAt(chance);
        }


        int malaysiaChance = 0;
        int chinaChance = 0;
        int indiaChance = 0;
        double foodMinus = 0;
        double waterMinus = 0;
        WaitForSeconds wait = new WaitForSeconds(1.2f);



        while (day <= 1470 && popularity > 35)
        {        
            food = 100 + additionalFoodProduced;
            foodMinus = food;
            water = 100 + additionalWaterProduced;
            waterMinus = water;
            energy = 100 + additionalEnergyProduced;
            energyDemand = 100 - energyDemandMinus;            
            description = " ";
            title = " ";
            disaster_name = " ";
            event_name = " ";
            information_name = " ";
            newsLength = news6.Count;

            yield return wait;

            if (bonusButton.activeSelf)
            {
                bonusButton.SetActive(false);
                bonusButton.gameObject.transform.Translate(-moveX, -moveY, 0);
            }

            if (day <= 150 && day % 50 == 0 && tutor == 1)
            {                
                openTutorial();
                tutortxt.text = tutorials[4 + day/50];                
            }

            if (disaster.ContainsKey(day))
            {
                disaster_name = disaster.FirstOrDefault(x => x.Key == day).Value;
                ongoingEvents.Add(disaster_name);

                if (disaster_name == "flood" || disaster_name == "flood1")
                {
                    title = "Singapore to experience flash floods";
                    description = "Flash floods are usually caused by intense rainfall. They are becoming more frequent and severe due to the rise in sea levels caused by the melting of ice caps around the world.";
                }

                else if (disaster_name == "floodEnd" || disaster_name == "floodEnd1")
                {
                    title = "Singapore to no longer experience flash floods";
                    if (disaster_name == "floodEnd") {
                        if (floodWallDay <= flood_day)
                        {
                            flood_deaths = Convert.ToInt32(flood_deaths * (100 - floodDeathReduce1) / 100);
                        }
                        else
                        {
                            flood_deaths = Convert.ToInt32(flood_deaths * (100 - floodDeathReduce1 * (flood_duration - (floodWallDay - flood_day)) / flood_duration) / 100);
                        }
                        if (warningSystemDay <= flood_day)
                        {
                            flood_deaths = Convert.ToInt32(flood_deaths * (100 - floodDeathReduce) / 100);
                        }
                        else
                        {
                            flood_deaths = Convert.ToInt32(flood_deaths * (100 - floodDeathReduce * (flood_duration - (warningSystemDay - flood_day)) / flood_duration) / 100);
                        }
                        description = "The recent spate of flash floods killed " + flood_deaths + " people.";
                        dead += Convert.ToInt32(flood_deaths);
                        totalFloodDeaths += Convert.ToInt32(flood_deaths);
                    }
                    else
                    {
                        if (floodWallDay <= flood_day1)
                        {
                            flood_deaths1 = Convert.ToInt32(flood_deaths1 * (100 - floodDeathReduce1) / 100);
                        }
                        else
                        {
                            flood_deaths1 = Convert.ToInt32(flood_deaths1 * (100 - floodDeathReduce1 * (flood_duration - (floodWallDay - flood_day1)) / flood_duration) / 100);
                        }
                        if (warningSystemDay <= flood_day1)
                        {
                            flood_deaths1 = Convert.ToInt32(flood_deaths1 * (100 - floodDeathReduce) / 100);
                        }
                        else
                        {
                            flood_deaths1 = Convert.ToInt32(flood_deaths1 * (100 - floodDeathReduce * (flood_duration - (warningSystemDay - flood_day1)) / flood_duration) / 100);
                        }
                        description = "The recent spate of flash floods killed " + flood_deaths1 + " people.";
                        dead += Convert.ToInt32(flood_deaths1);
                        totalFloodDeaths += Convert.ToInt32(flood_deaths1);
                    }
                    ongoingEvents.Remove("flood");
                    Tempfw1.interactable = true;
                    Tempfw2.interactable = true;
                    Tempfw3.interactable = true;
                    Tempfw2.gameObject.SetActive(false);
                    Tempfw3.gameObject.SetActive(false);
                    floodDeathReduce1 = 0;
                }


                else if (disaster_name == "heatWave" || disaster_name == "heatWave1")
                {
                    if (ongoingEvents.Contains("drought"))
                    {
                        title = "Singapore to experience heat waves";
                        description = "The weather in Singapore will be exceptionally hot during this period of time. Heat waves are becoming more frequent and severe due to climate change driven by global warming. The ongoing drought will worsen the effects of this heat wave.";
                    }
                    else
                    {
                        title = "Singapore to experience heat waves";
                        description = "The weather in Singapore will be exceptionally hot during this period of time. Heat waves are becoming more frequent and severe due to climate change driven by global warming.";
                    }
                }

                else if (disaster_name == "heatWaveEnd" || disaster_name == "heatWaveEnd1")
                {

                    if (disaster_name == "heatWaveEnd")
                    {
                        if (educationDay <= heatWave_day)
                        {
                            heatWave_deaths = Convert.ToInt32(heatWave_deaths * (100 - educationReduce) / 100);
                            description = "The heat waves have indirectly resulted in the deaths of " + heatWave_deaths + " people.";
                        }
                        else
                        {
                            heatWave_deaths = Convert.ToInt32(heatWave_deaths * (100 - educationReduce * (heatWave_duration - (educationDay - heatWave_day)) / heatWave_duration) / 100);
                            description = "The heat waves have indirectly resulted in the deaths of " + heatWave_deaths + " people.";                            
                        }
                        dead += heatWave_deaths;
                        totalHeatWaveDeaths += heatWave_deaths;
                    }

                    else
                    {
                        if (educationDay <= heatWave_day1)
                        {
                            heatWave_deaths1 = Convert.ToInt32(heatWave_deaths1 * (100 - educationReduce) / 100);
                            description = "The heat waves have indirectly resulted in the deaths of " + heatWave_deaths1 + " people.";
                        }
                        else
                        {
                            heatWave_deaths1 = Convert.ToInt32(heatWave_deaths1 * (100 - educationReduce * (heatWave_duration - (educationDay - heatWave_day1)) / heatWave_duration) / 100);
                            description = "The heat waves have indirectly resulted in the deaths of " + heatWave_deaths1 + " people.";                            
                        }
                        dead += heatWave_deaths1;
                        totalHeatWaveDeaths += heatWave_deaths1;
                    }
                    title = "Singapore to no longer experience heatwaves";
                    ongoingEvents.Remove("heatWave");                  
                }

                else if (disaster_name == "drought" || disaster_name == "drought1")
                {
                    title = "Singapore to experience droughts";
                    description = "There will be little to no rain in Singapore for this period of time. Droughts are becoming more frequent and severe due to climate change driven by global warming.";
                }

                else if (disaster_name == "droughtEnd" || disaster_name == "droughtEnd1")
                {
                    title = "Singapore to no longer experience droughts";
                    description = "It is unclear as to whether Singapore will experience such droughts in the future.";
                    ongoingEvents.Remove("drought");
                    Seeding1.interactable = true;
                    Seeding2.interactable = true;
                    Seeding3.interactable = true;
                    Seeding2.gameObject.SetActive(false);
                    Seeding3.gameObject.SetActive(false);
                    waterPlusDuringDrought = 0;

                    if (difficulty == 1)
                    {
                        if (task2Status == "(-)")
                        {
                            task2Status = "(completed)";
                        }                      
                    }

                    else
                    {
                        if (task2Status == "(-)" && disaster_name == "droughtEnd1")
                        {
                            task2Status = "(completed)";
                        }
                    }
                }

                else if (disaster_name == "ricePlague")
                {
                    title = "Rice crops worldwide infected with rice blast fungus";
                    description = "This will cause worldwide rice production to decrease significantly for a period of time.";
                    if (shortagevalue == true)
                    {
                        news6.Add("Panic buying ensues; Singaporeans stocking up on rice");
                    }
                }

                else if (disaster_name == "ricePlagueImpact")
                {
                    title = "Rice imports into Singapore decreasing significantly";
                    description = "This is due to the rice blast epidemic. It is unclear when the global supply of rice will recover.";
                }

                else if (disaster_name == "ricePlagueEnd")
                {
                    title = "Rice blast fungus no longer affecting most rice crops worldwide";
                    description = "Worldwide rice production will increase back to setpoint soon.";
                }

                else if (disaster_name == "ricePlagueImpactEnd")
                {
                    ongoingEvents.Remove("ricePlagueImpact");
                }

                else if (disaster_name == "bananaPlague")
                {
                    title = "Banana trees worldwide infected with Panama disease";
                    description = "This will cause worldwide banana production to decrease significantly for a period of time.";
                }

                else if (disaster_name == "bananaPlagueImpact")
                {
                    title = "Banana imports into Singapore decreasing significantly";
                    description = "This is due to the global Panama disease outbreak. It is unclear when the global supply of bananas will recover.";
                }

                else if (disaster_name == "bananaPlagueEnd")
                {
                    title = "Panama disease no longer affecting most banana crops worldwide";
                    description = "Worldwide banana production will increase back to setpoint soon.";
                }

                else if (disaster_name == "bananaPlagueImpactEnd")
                {
                    ongoingEvents.Remove("bananaPlagueImpact");
                }

                else if (disaster_name == "indiaDrought")
                {
                    indiaChance = rnd.Next(2);
                    if (indiaChance == 0)
                    {
                        title = "India facing a major drought";
                        description = "Whilst India has always faced droughts, climate change driven by global warming has resulted in droughts becoming even more common and severe.";
                    }
                    else
                    {
                        title = "Monsoon rains to India much lower and later than usual";
                        description = "Whilst monsoon rains always differ in intensity and duration, climate change driven by global warming has resulted in rainfall patterns becoming even more abnormal.";
                    }
                }

                else if (disaster_name == "indiaDroughtImpact")
                {
                    if (indiaChance == 0)
                    {
                        title = "Food imports from India into Singapore decreasing significantly";
                        description = "This is because India is facing a major drought.";
                    }
                    else
                    {
                        title = "Food imports from India into Singapore decreasing significantly";
                        description = "This is because monsoon rains to India are much lower and later than normal.";
                    }
                    if (shortagevalue == true)
                    {
                        news6.Add("Panic buying ensues; local supermarkets overwhelmed");
                    }
                }

                else if (disaster_name == "indiaDroughtEnd")
                {
                    title = "India's food production has recovered";
                    description = "As such, Singapore will be able to import more food from India soon.";
                }

                else if (disaster_name == "indiaDroughtImpactEnd")
                {
                    ongoingEvents.Remove("indiaDroughtImpact");
                }

                else if (disaster_name == "chinaDrought")
                {
                    chinaChance = rnd.Next(2);
                    if (chinaChance == 0)
                    {
                        title = "China facing a major drought";
                        description = "Whilst differnt parts of China have always faced droughts, climate change driven by global warming has resulted in droughts becoming even more common and severe.";
                    }
                    else
                    {
                        title = "China experiencing highly abnormal weather";
                        description = "Some parts of China are experiencing rains much longer and intense than normal whilst other parts are experiencing the exact opposite. This can be attributed to climate change driven by global warming.";
                    }
                }

                else if (disaster_name == "chinaDroughtImpact")
                {
                    if (chinaChance == 0)
                    {
                        title = "Food imports from China into Singapore decreasing significantly";
                        description = "This is because China is experiencing a major drought.";
                    }
                    else
                    {
                        title = "Food imports from China into Singapore decreasing significantly";
                        description = "This is because China is experiencing experiencing highly abnormal weather. Both prolonged periods of high rainfall and low rainfall are contributing to the significant decline in China's food production.";
                    }
                    if (shortagevalue == true)
                    {
                        news6.Add("Panic buying ensues; local supermarkets overwhelmed");
                    }
                    arbitary = rnd.Next(11, 31);
                    popularity -= arbitary / 100;
                }

                else if (disaster_name == "chinaDroughtEnd")
                {
                    title = "China's food production has recovered";
                    description = "As such, Singapore will be able to import more food from China soon.";
                }

                else if (disaster_name == "chinaDroughtImpactEnd")
                {
                    ongoingEvents.Remove("chinaDroughtImpact");
                }

                else if (disaster_name == "malaysiaDrought")
                {
                    malaysiaChance = rnd.Next(2);
                    if (malaysiaChance == 0)
                    {
                        title = "Malaysia facing a major drought";
                        description = "Whilst Malaysia does not often experience droughts, climate change driven by global warming has resulted in droughts becoming even more common and severe.";
                    }
                    else
                    {
                        title = "Malaysia experiencing highly abnormal weather";
                        description = "Some parts of Malaysia are experiencing rains much longer and intense than normal whilst other parts are experiencing the exact opposite. This can be attributed to climate change driven by global warming.";
                    }
                }

                else if (disaster_name == "malaysiaDroughtImpact")
                {
                    if (malaysiaChance == 0)
                    {
                        title = "Food imports from Malaysia into Singapore decreasing significantly";
                        description = "This is because Malaysia is experiencing a major drought.";
                    }
                    else
                    {
                        title = "Food imports from Malaysia into Singapore decreasing significantly";
                        description = "This is because Malaysia is experiencing experiencing highly abnormal weather. Both prolonged periods of high rainfall and low rainfall are contributing to the significant decline in Malaysia's food production.";
                    }
                    if (shortagevalue == true)
                    {
                        news6.Add("Panic buying ensues; local supermarkets overwhelmed");
                    }
                }

                else if (disaster_name == "malaysiaDroughtImpact1")
                {
                    if (malaysiaChance == 0)
                    {
                        title = "Water level at Linggiu Reservoir in Johor, Malaysia drops drastically";
                        description = "This is because Malaysia is experiencing a major drought. Malaysia will be exporting much less water to Singapore for this period of time.";
                    }
                    else
                    {
                        title = "Water level at Linggiu Reservoir in Johor, Malaysia drops drastically";
                        description = "This is due to the ongoing dry weather. Malaysia will be exporting much less water to Singapore for this period of time.";
                    }
                }

                else if (disaster_name == "malaysiaDroughtEnd")
                {
                    title = "Malaysia's food production has recovered";
                    description = "As such, Singapore will be able to import more food from Malaysia soon.";
                }

                else if (disaster_name == "malaysiaDroughtEnd1")
                {
                    title = "Water level at Linggiu Reservoir in Johor, Malaysia has recovered";
                    description = "As such, Singapore will be able to import more water from Malaysia soon.";
                }

                else if (disaster_name == "malaysiaDroughtImpactEnd")
                {
                    ongoingEvents.Remove("malaysiaDroughtImpact");
                    if (difficulty > 1)
                    {
                        ongoingEvents.Remove("malaysiaDroughtImpact1");
                    }
                }

                else if (disaster_name == "haze")
                {
                    title = "Singapore shrouded in smog";
                    description = "The smog, also known as ‘haze’, has been caused by the burning of forests in nearby countries. Singapore’s air quality has hit unhealthy levels overnight.";
                }

                else if (disaster_name == "hazeEnd")
                {
                    title = "Singapore no longer shrouded in smog";
                    description = "Singapore’s air quality is now in the acceptable range.";
                    ongoingEvents.Remove("haze");
                }

                else if (disaster_name == "worldwar")
                {
                    title = "World War 3 has broken out";
                    description = "While Singapore will not be involved in fighting, such a war will have a significant impact on Singapore’s food supply.";
                }

                else if (disaster_name == "worldwar_end")
                {
                    title = "World War 3 has ended";
                    description = "Food imports into Singapore will recover soon.";
                }

                else if (disaster_name == "nuclearwar")
                {
                    title = "A massive nuclear war has taken place";
                    description = "The scale of the nuclear war has caught the world by surprise. Food imports from many countries will decrease significantly for the rest of your term.";
                }

                else if (disaster_name == "massInsectExtinction")
                {
                    title = "Mass insect extinction taking place";
                    description = "The population of bees, butterflies, and moths is dwindling drastically as their habitats become unlivable. This is due to climate change driven by global warming. Whilst worldwide production of fruits and vegetables will not decrease immediately, it is set to decrease in the next few years to come.";
                }

                else if (disaster_name == "massInsectExtinction_impact")
                {
                    title = "Worldwide production of fruits and vegetables decreasing significantly";
                    description = "This is due to the ongoing mass insect extinction.";
                }

                else if (disaster_name == "temperatureIncrease")
                {
                    title = "Temperature in Singapore steadily increasing";
                    description = "This is due to global warming. Temperature, and thus energy demand, will increase gradually throughout the game (due to the increase in the use of air conditioners). During the rainy months, temperature, and thus energy demand will drop back to setpoint.";
                }

                //action
                if (disaster_name != "ricePlagueImpactEnd" && disaster_name != "bananaPlagueImpactEnd" && disaster_name != "chinaDroughtImpactEnd" && disaster_name != "indiaDroughtImpactEnd" && disaster_name != "malaysiaDroughtImpactEnd")
                {
                    events1.SetActive(true);
                    eventtitle.text = title;
                    eventtxt.text = description;
                    Time.timeScale = 0;
                }
            }

            else if (events.ContainsKey(day))
            {
                event_name = events.FirstOrDefault(x => x.Key == day).Value;

                if (event_name == "heatWaveCloseFacilities" || event_name == "heatWaveCloseFacilities1")
                {
                    description = "Singapore is currently facing a heat wave. Will your government ban the consumption of alcohol and the use of outdoor facilities from 9.00 am to 6.00 pm for this period of time?";
                    cost = 0;
                }

                else if (event_name == "heatWaveCloseConstruction" || event_name == "heatWaveCloseConstruction1")
                {
                    description = "Singapore is currently facing a heat wave. Will your government mandate that construction companies stop operations for this period of time?";
                    cost = 0;
                }

                else if (event_name == "donateMasks")
                {
                    description = "Singapore is currently shrouded in haze. Will your government spend 15 development points to distribute 1 million N95 masks to 250 thousand needy families in Singapore?";
                    cost = 15;
                }

                else if (event_name == "plasticTax")
                {
                    description = "Would your government enforce a tax on the use of plastics? While such a decision will be popular with the environmentally conscious, it will still be a rather unpopular decision.";
                    cost = 0;
                }

                else if (event_name == "regulatePrices")
                {
                    description = "Prices of certain food items have increased substantially. Will your government regulate the price of staple foods such as rice?";
                    cost = 0;
                }

                else if (event_name == "supportNeedyFamilies")
                {
                    if (additionalFoodSupplied >= 3 && foodSufficiency > 50)
                    {
                        description = "Due to increasing food prices, needy families are finding it harder to buy food. Will your government give out food you previously stored to these families?";
                        cost = 0;
                        additionalFoodSupplied -= 3;
                    }
                    else
                    {
                        description = "Due to increasing food prices, needy families are finding it harder to buy food. Will your government spend 15 development points to support these families for this period of time?";
                        cost = 15;
                    }
                }

                else if (event_name == "recyclePlastics")
                {
                    description = "Would your government spend 15 development points on doubling the number of recycling bins and promoting initiatives such as 'cash for trash'?";
                    cost = 15;
                }

                else if (event_name == "recycleElectronics")
                {
                    description = "Would your government spend 10 development points on encouraging companies nationwide to take part in the National Voluntary Partnership for E-Waste Recycling and provide cash incentives for them to do so?";
                    cost = 10;
                }

                else if (event_name == "gotTalentShow")
                {
                    description = "MediaComp is thinking of starting a Singapore Got Talent show. Would you spend 15 development points to subsidise the creation of such a show?";
                    cost = 15;
                }


                choice.SetActive(true);
                choicetitle.text = title;
                choicetxt.text = description;
                Time.timeScale = 0;

                //money checker
                if (cost > money) {
                    yestxt.text = "";
                    notxt.text = "I'm broke";
                    yes.interactable = false;
                }
                else if (cost <= money)
                {
                    yestxt.text = "Yes";
                    notxt.text = "No";
                    yes.interactable = true;
                }
                yield return new WaitWhile(() => opt == "");

                if (event_name == "heatWaveCloseFacilities" || event_name == "heatWaveCloseFacilities1")
                {
                    if (opt == "yes")
                    {
                        arbitary = rnd.Next(30, 51 + (3 - difficulty) * 15);                        
                        popularity -= arbitary / 100; ;
                        if (event_name == "heatWaveCloseFacilities") 
                        {
                            heatWave_deaths = Convert.ToInt32(heatWave_deaths / 2);
                        }
                        else 
                        {
                            heatWave_deaths1 = Convert.ToInt32(heatWave_deaths1 / 2);
                        }
                        news6.Add("Some Singaporeans unhappy with your government's way of handling the ongoing heat wave; label it as 'too restrictive'");
                    }
                }

                else if (event_name == "heatWaveCloseConstruction" || event_name == "heatWaveCloseConstruction1")
                {
                    if (opt == "yes")
                    {
                        arbitary = rnd.Next(10, 21 + (3 - difficulty) * 5);
                        popularity -= arbitary / 100; ;
                        if (event_name == "heatWaveCloseConstruction") 
                        {
                            heatWave_deaths = Convert.ToInt32(heatWave_deaths / 5 * 4);
                        }
                        else 
                        {
                            heatWave_deaths1 = Convert.ToInt32(heatWave_deaths1 / 5 * 4);
                        }
                    }
                }

                else if (event_name == "donateMasks")
                {
                    if (opt == "yes")
                    {
                        popularity += 0.35;
                        money -= 15;
                    }
                    else if (opt == "no")
                    {
                        popularity -= 0.10;
                    }
                }
               

                else if (event_name == "plasticTax")
                {
                    if (opt == "yes")
                    {
                        arbitary = rnd.Next(30, 51);
                        popularity -= arbitary / 100;
                        ecoFriendlyInitiative += 1;
                    }
                }

                else if (event_name == "regulatePrices")
                {
                    if (opt == "yes")
                    {
                        arbitary = rnd.Next(20, 41);
                        popularity += arbitary / 100;
                    }
                }        

                else if (event_name == "supportNeedyFamilies")
                {
                    if (additionalFoodSupplied < 14)
                    {
                        if (opt == "yes")
                        {
                            money -= 15;
                            arbitary = rnd.Next(30, 81);
                            popularity += arbitary / 100;
                        }
                        else if (opt == "no")
                        {
                            arbitary = rnd.Next(20, 61);
                            popularity -= arbitary / 100;
                        }
                    }
                    else
                    {
                        if (opt == "yes")
                        {
                            arbitary = rnd.Next(30, 81);
                            popularity += arbitary / 100;
                        }
                        else if (opt == "no")
                        {
                            arbitary = rnd.Next(20, 61);
                            popularity -= arbitary / 100;
                        }
                    }
                }

                else if (event_name == "recyclePlastics")
                {
                    if (opt == "yes")
                    {
                        arbitary = rnd.Next(25, 36);
                        popularity += arbitary / 100;
                        money -= 15;
                        ecoFriendlyInitiative += 1;
                    }
                }

                else if (event_name == "recycleElectronics")
                {
                    if (opt == "yes")
                    {
                        arbitary = rnd.Next(15, 26);
                        popularity += arbitary / 100;
                        money -= 10;
                        ecoFriendlyInitiative += 1;
                    }
                }

                else if (event_name == "gotTalentShow")
                {
                    if (opt == "yes")
                    {
                        arbitary = rnd.Next(20, 71);
                        popularity += arbitary / 100;
                        money -= 15;
                    }
                }
                opt = "";
            }

            else if (information.ContainsKey(day))
            {
                information_name = information.FirstOrDefault(x => x.Key == day).Value;

                if (information_name == "solarCommendation")
                {
                    title = "Solar energy now meets " + Convert.ToInt32((solar_level - 1) * 10) + "% of Singapore's energy demand";
                    description = "This is because your government chose to invest in solar energy in 2028. The general public is happy that your government has taken signficant steps to decrease Singapore's reliance on fossil fuels.";
                }

                else if (information_name == "foodCommendation")
                {
                    title = "Food prices in Singapore have fallen";
                    description = "This is because your government helped to increase local food production. The general public is happy.";
                }

                if (information_name == "waterCommendation")
                {
                    title = "Water prices in Singapore have fallen";
                    description = "This is because your government helped to increase local water production. As the majority of Singapore's water usage is non-domestic, the impact on normal citizens is not as profound.";
                }

                events1.SetActive(true);
                eventtitle.text = title;
                eventtxt.text = description;
                Time.timeScale = 0;
            }

            else if (rnd.Next(7) < 2) //2 in 7 chance
            {
                if (day % 10 == 0 && day != 10 && day != 50 && day != 100 && day != 150)
                {
                    openDevBonus();
                }
            }



            //impacts
            if (ongoingEvents.Contains("drought"))
            {
                arbitary = rnd.Next(11);
                if (rnd.Next(2) == 0)
                {
                    arbitary = -arbitary;
                }
                water -= 10 + arbitary / 10 - waterPlusDuringDrought;
                if (waterPlusDuringDrought < 6)
                {
                    task2Status = "(failed)";
                }
            }

            if (ongoingEvents.Contains("heatWave"))
            {
                energySwitch = "on";
                if (ongoingEvents.Contains("drought"))
                {
                    energyDemand += (difficulty) * 4;
                }
                else
                {
                    energyDemand += (difficulty) * 6;
                }
            }

            if (ongoingEvents.Contains("massInsectExtinction_impact"))
            {
                if (difficulty == 1)
                {
                    arbitary = rnd.Next(5);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 4 + arbitary / 10;
                }
                else if (difficulty == 2)
                {
                    arbitary = rnd.Next(6);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 5 + arbitary / 10;
                }
                else
                {
                    arbitary = rnd.Next(8);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 7 + arbitary / 10;
                }
            }

            if (ongoingEvents.Contains("ricePlagueImpact"))
            {
                if (difficulty == 1)
                {
                    arbitary = rnd.Next(38);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 3.7 + arbitary / 100;
                }
                else if (difficulty == 2)
                {
                    arbitary = rnd.Next(56);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 5.5 + arbitary / 100;
                }
                else if (difficulty == 3)
                {
                    arbitary = rnd.Next(93);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 9.2 + arbitary / 100;
                }
            }

            if (ongoingEvents.Contains("bananaPlagueImpact"))
            {
                if (difficulty == 1)
                {
                    arbitary = rnd.Next(10);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 0.9 + arbitary / 100;
                }
                else if (difficulty == 2)
                {
                    arbitary = rnd.Next(13);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 1.2 + arbitary / 100;
                }
                else if (difficulty == 3)
                {
                    arbitary = rnd.Next(19);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 1.8 + arbitary / 100;
                }
            }

            if (ongoingEvents.Contains("indiaDroughtImpact"))
            {
                if (difficulty == 1)
                {
                    arbitary = rnd.Next(25);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 2.4 + arbitary / 100;
                }
                else if (difficulty == 2)
                {
                    arbitary = rnd.Next(33);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 3.2 + arbitary / 100;
                }
                else if (difficulty == 3)
                {
                    arbitary = rnd.Next(49);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 4.8 + arbitary / 100;
                }
            }

            if (ongoingEvents.Contains("chinaDroughtImpact"))
            {
                if (difficulty == 1)
                {
                    arbitary = rnd.Next(3);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 2 + arbitary / 10;
                }
                else if (difficulty == 2)
                {
                    arbitary = rnd.Next(4);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 3 + arbitary / 10;
                }
                else if (difficulty == 3)
                {
                    arbitary = rnd.Next(6);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 5 + arbitary / 10;
                }
            }

            if (ongoingEvents.Contains("malaysiaDroughtImpact"))
            {
                if (difficulty == 1)
                {
                    arbitary = rnd.Next(28);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 2.7 + arbitary / 100;
                }
                else if (difficulty == 2)
                {
                    arbitary = rnd.Next(55);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 5.4 + arbitary / 100;
                }
                else if (difficulty == 3)
                {
                    arbitary = rnd.Next(109);
                    if (rnd.Next(2) == 0)
                    {
                        arbitary = -arbitary;
                    }
                    food -= 10.8 + arbitary / 100;
                }
            }

            if (ongoingEvents.Contains("malaysiaDroughtImpact1"))
            {
                water -= 1 + (difficulty) * 5 + rnd.Next(difficulty + 1);
            }

            if (ongoingEvents.Contains("worldwar") || ongoingEvents.Contains("nuclearwar"))
            {
                if (ongoingEvents.Contains("nuclearwar")) 
                {
                    food -= 28;
                }
                else
                {                   
                    food -= 14;
                }
            }

            if (ongoingEvents.Contains("temperatureIncrease") && day % 360 < 300 && day % 360 > 30)
            {
                energyDemand += day / 10 * (difficulty) / 10;
                energySwitch = "on";
            }

            else
            {
                energySwitch = "off";
            }


            foodMinus -= food;
            waterMinus -= water;
            foodSufficiency = Convert.ToInt32(food / foodDemand * 100);
            waterSufficiency = Convert.ToInt32(water / waterDemand * 100);
            energySufficiency = Convert.ToInt32(energy / energyDemand * 100);



            //popularity rating up/down
            if (foodSufficiency <= 90)
            {
                if (rnd.Next(11) == 10 && supportNeedyFamiliesX > 160)
                {
                    if (events.ContainsKey(day + 10) == false)
                    {
                        events.Add(day + 10, "supportNeedyFamilies");
                    }
                    supportNeedyFamiliesX = 0;
                }
                supportNeedyFamiliesX += 10;

                if (foodSufficiency < 75 && starvationSwitch1 == " ")
                {
                    news6.Add("Ultra-wealthy Singaporeans leaving Singapore to become farmers in New Zealand");
                    starvationSwitch1 = "activated";
                }

            }

            if (difficulty == 1)
            {

                if (foodMinus > 1) //at most points in the game, food supply is down by 1-11% 
                {
                    if (foodSufficiency > 99) //increase food sufficiency by at least 10%
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity += arbitary / 50;
                    }
                    else
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity -= arbitary / 50;
                    }
                }

                if (energySwitch == "on") //due to increasing temperatures, energy demand is up by 10%
                {
                    if (energySufficiency > 99) //increase energy sufficiency by at least 10%
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity += arbitary / 250;
                    }
                    else
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity -= arbitary / 125;
                    }
                }

                if (waterMinus > 1) //during droughts water is down by 10%
                {
                    if (waterSufficiency > 99) //increase water sufficiency by at least 10%
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity += arbitary / 250;
                    }
                    else
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity -= arbitary / 125;
                    }
                }

            }


            else if (difficulty == 2)
            {

                if (foodMinus < 15)
                {
                    if (energySwitch == "on")
                    {
                        if (energySufficiency > 94) //increase energy sufficiency by at least 15%
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity += arbitary / 250;
                        }
                        else
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity -= arbitary / 125;
                        }
                    }

                    if (waterMinus > 20) //when Malaysia ain't importing water to Singapore & there's a drought
                    {
                        if (waterSufficiency > 84) //increase water sufficiency by at least 15%
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity += arbitary / 250;
                        }
                        else
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity -= arbitary / 125;
                        }
                    }

                    else if (waterMinus > 10) //when Malaysia ain't importing water to Singapore
                    {
                        if (waterSufficiency > 94) //increase water sufficiency by at least 15%
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity += arbitary / 250;
                        }
                        else
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity -= arbitary / 125;
                        }
                    }

                    else if (waterMinus > 1) //when there's a drought
                    {
                        if (waterSufficiency > 99) //increase water sufficiency by at least 10%
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity += arbitary / 250;
                        }
                        else
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity -= arbitary / 125;
                        }
                    }

                    if (foodMinus > 5)
                    {
                        if (foodSufficiency > 90) //increase food by at least 10%
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity += arbitary / 50;
                        }

                        else
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity -= arbitary / 35;
                        }
                    }
                }

                else
                {
                    if (foodSufficiency > 77) //increase food by at least 10%
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity += arbitary / 50;
                    }

                    else
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity -= arbitary / 35;
                    }
                }

            }


            else if (difficulty == 3)
            {

                if (foodMinus < 15) //occurs in first six and last six months of game
                {
                    if (energySwitch == "on")
                    {
                        if (energySufficiency > 88) //increase energy sufficiency by at least 15%
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity += arbitary / 250;
                        }
                        else
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity -= arbitary / 125;
                        }
                    }

                    if (waterMinus > 20) //when Malaysia ain't importing water to Singapore & there's a drought
                    {
                        if (waterSufficiency > 84) //increase water sufficiency by at least 15%
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity += arbitary / 250;
                        }
                        else
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity -= arbitary / 125;
                        }
                    }

                    else if (waterMinus > 10) //when Malaysia ain't importing water to Singapore
                    {
                        if (waterSufficiency > 94) //increase water sufficiency by at least 15%
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity += arbitary / 250;
                        }
                        else
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity -= arbitary / 125;
                        }
                    }

                    else if (waterMinus > 1) //when there's a drought
                    {
                        if (waterSufficiency > 99) //increase water sufficiency by at least 10%
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity += arbitary / 250;
                        }
                        else
                        {
                            arbitary = rnd.Next(1, 11);
                            popularity -= arbitary / 125;
                        }
                    }
                }

                else
                {
                    if (foodSufficiency > 49)
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity += arbitary / 35;
                    }

                    else
                    {
                        arbitary = rnd.Next(1, 11);
                        popularity -= arbitary / 35;
                    }
                }

            }



            arbitary = rnd.Next(6);
            if (rnd.Next(2) == 0)
            {
                popularity += arbitary / 100;
            }
            else
            {
                popularity -= arbitary / 100;
            }

            if (rnd.Next(101) > waterSufficiency && foodSufficiency > 75)
            {
                if (rnd.Next(2) == 1) {
                    if (shortagevalue == true)
                    {
                        news6.Add("Water shortage temporarily halts operations of certain companies");
                    }
                    arbitary = rnd.Next(20, 41);
                    popularity -= arbitary / 100;
                    moneyPlus -= 3;
                }
            }

            if (rnd.Next(101) > energySufficiency)
            {                
                if (shortagevalue == true)
                {
                    x = rnd.Next(44);
                    cityName = cityList[x];
                    news6.Add("Power outage ensues in " + cityName);
                }
                arbitary = rnd.Next(20, 41);
                popularity -= arbitary / 100;
                moneyPlus -= 3;
            }

            if (moneyPlus < 0)
            {
                moneyPlus = 0;
            }

            if (day % 10 == 0)
            {
                money += moneyPlus;
                moneyPlus = rnd.Next(3, 6);
            }



            if (foodSufficiency < 50)
            {
                daysWithoutFood += 1;
                if (daysWithoutFood > 5)
                {
                    if (additionalFoodSupplied > 0)
                    {
                        if (starvationSwitch4 == " ")
                        {
                            news6.Add("Singapore's food reserves being used");
                            starvationSwitch4 = "activated";
                        }
                        additionalFoodSupplied -= 1;
                    }
                    else
                    {
                        arbitary = rnd.Next(30, 50) * (daysWithoutFoodX) * (daysWithoutFoodX / 2);
                        dead += Convert.ToInt32(arbitary);
                        popularity -= daysWithoutFoodX * daysWithoutFoodX / 60;
                        daysWithoutFoodX += 1;
                        news6.Add(arbitary + " die due to starvation");
                    }

                    if (daysWithoutFood == 10 && starvationSwitch3 == " ")
                    {
                        news6.Add("It is a matter of time before you lose the game... better luck next time");
                        starvationSwitch3 = "activated";
                    }
                }

                else if (daysWithoutFood == 3 && starvationSwitch2 == " " && foodSufficiency <= 47)
                {
                    news6.Add("Due to mass starvation, hospitals in Singapore are being overwhelmed");
                    starvationSwitch2 = "activated";
                }
            }

            else
            {
                daysWithoutFood = 0;
                daysWithoutFoodX = 3;
            }



            //random news updates
            arbitary = rnd.Next(7);
            if (arbitary == 0 && foodSufficiency >= 75)
            {
                x = rnd.Next(20);
                if (x < 13 && currentsvalue == true)
                {
                    x = rnd.Next(currentAffairs.Count);
                    description = currentAffairs[x];
                    currentAffairs.RemoveAt(x);
                    news6.Add(description);
                }
                else if (x >= 13 && jokesvalue == true)
                {
                    x = rnd.Next(jokesAndTips.Count);
                    description = jokesAndTips[x];
                    jokesAndTips.RemoveAt(x);
                    news6.Add(description);
                }
            }


            //world cup update
            if (sportvalue == true)
            {
                if (day < 180)
                {
                    if (day == 70)
                    {
                        x = rnd.Next(4);
                        news6.Add(sportsUpdates[x]);
                        if (x < 2)
                        {
                            arbitary = rnd.Next(20, 31);
                            popularity += arbitary / 100;
                            worldCupSwitch1 = "on";
                        }
                    }

                    else if (day == 140 && worldCupSwitch1 == "on")
                    {
                        x = rnd.Next(4, 8);
                        news6.Add(sportsUpdates[x]);
                        if (x > 5)
                        {
                            arbitary = rnd.Next(40, 61);
                            popularity += arbitary / 100;
                            worldCupSwitch2 = "on";
                        }
                    }

                    else if (day == 160 && worldCupSwitch2 == "on")
                    {
                        x = rnd.Next(8, 10);
                        news6.Add(sportsUpdates[x]);
                        if (x < 9)
                        {
                            arbitary = rnd.Next(50, 101);
                            popularity += arbitary / 100;
                            worldCupSwitch3 = "on";
                        }
                    }

                    else if (day == 170 && worldCupSwitch3 == "on")
                    {
                        news6.Add(sportsUpdates[10]);
                    }
                }

                if (day == 100)
                {
                    news6.Add(sportsUpdates[28]);
                }

                else if (day == 520 && difficulty < 3)
                {
                    sportsX = rnd.Next(11, 18);
                    news6.Add(sportsUpdates[sportsX]);
                    if (sportsX == 11)
                    {
                        news6.Add("Thierry Henry to take over as Arsenal manager");
                    }
                    else if (sportsX == 13)
                    {
                        news6.Add("40 year-old Harry Kane cries tears of joy after winning his first trophy with Spurs");
                    }
                    else if (sportsX == 14)
                    {
                        news6.Add("'We got sick of winning' comments Newcastle United manager after his team loses to Liverpool in Champions League Final");
                    }
                    else if (sportsX == 17)
                    {
                        news6.Add("Conor McGregor buys over Manchester United");
                    }
                }

                else if (day == 880 && difficulty < 3)
                {
                    if (sportsX == 11)
                    {
                        news6.Add("Bayuko Saka and Smith Rowe carry Arsenal to Premier League title");
                    }
                    else if (sportsX == 17)
                    {
                        news6.Add("Mason Greenwood and Jadon Sancho carry Manchester United to Premier League Title");
                    }
                    else
                    {
                        news6.Add("Scientists build robots capable of challenging professional football players; 'Robots vs Humans' football match to take place soon");
                        sportsY = "on";
                    }
                }

                else if (day == 910 && difficulty < 3 && sportsY == "on")
                {
                    x = rnd.Next(25, 28);
                    news6.Add(sportsUpdates[x]);
                }


                else if (day == 1240 && difficulty < 3)
                {
                    news6.Add("Scientists build robots capable of challenging professional basketball players; 'Robots vs Humans' basketball match to take place soon");
                }

                else if (day == 1270 && difficulty < 3)
                {
                    x = rnd.Next(30, 34);
                    news6.Add(sportsUpdates[x]);
                    if (x == 33)
                    {
                        news6.Add("'So what? They've got less personality than Kawhi Leonard!' chant fans after the 'Team Humans' loss");
                    }
                }
            }



            if (news6.Count > newsLength)
            {
                circle.SetActive(true);
            }


            if (foodSufficiency < 75)
            {
                foodCampaignSwitch = "on";
                if (foodSufficiency < 50)
                {
                    day += 1;
                }
                else
                {
                    day += 10;
                }
            }
            else
            {
                foodCampaignSwitch = "off";
                if (day % 10 == 0)
                {
                    day += 10;
                }
                else
                {
                    day += 10 - (day % 10);
                }
            }


            if (day > 1300)
            {
                if (EvSwitch == "on" && solar_level > 1)
                {
                    if (teslaSwitch == " ")
                    {
                        news6.Add("Tesla to open regional headquarters in Singapore");
                        task4Status = "(completed)";
                        teslaSwitch = "off";
                    }
                }
            }

            printm();
            printrest(foodSufficiency.ToString(), waterSufficiency.ToString(), energySufficiency.ToString(), dead.ToString());
            printration((additionalFoodSupplied).ToString(), (additionalWaterSupplied).ToString());
            printothers();
        }

        GAME.SetActive(false);
        gameend.SetActive(true);


        if (randomTask1 == 0)
        {
            if (task1Status == "(completed)")
            {
                tasksCompleted += 1;
            }
        }
        else if (randomTask1 == 1)
        {
            if (task2Status == "(completed)")
            {
                tasksCompleted += 1;
            }
        }
        else
        {
            if (money >= 100)
            {
                tasksCompleted += 1;
            }
        }

        if (randomTask2 == 3)
        {
            if (task2Status == "(completed)")
            {
                tasksCompleted += 1;
            }
        }
        else if (randomTask2 == 4)
        {
            if (ecoFriendlyInitiative >= 3)
            {
                tasksCompleted += 1;
            }
        }
        else
        {
            if (ecoFriendlySubsidies >= 5)
            {
                tasksCompleted += 1;
            }
        }


        if (difficulty == 1)
        {
            if (heatWave_deaths <= heatWaveRequirement[0])
            {
                tasksCompleted += 1;
            }
            if (flood_deaths <= floodRequirement[0])
            {
                tasksCompleted += 1;
            }
        }
        else
        {
            if (heatWave_deaths + heatWave_deaths1 <= heatWaveRequirement[difficulty - 1])
            {
                tasksCompleted += 1;
            }
            if (flood_deaths + flood_deaths1 <= floodRequirement[difficulty - 1])
            {
                tasksCompleted += 1;
            }
        }

        if (Convert.ToInt32(popularity) + tasksCompleted >= 75)
        {
            status = "Excellent";
	        nstar1.SetActive(false);
	        nstar2.SetActive(false);
	        nstar3.SetActive(false);
        }
        else if (Convert.ToInt32(popularity) + tasksCompleted >= 65)
        {
            status = "Good";
	        nstar1.SetActive(false);
	        nstar2.SetActive(false);
        }
        else if (Convert.ToInt32(popularity) + tasksCompleted >= 55)
        {
            status = "Average";
            nstar1.SetActive(false);
        }
        else if (Convert.ToInt32(popularity) + tasksCompleted < 55)
        {
            status = "Unsuccessful";
        }

        if (difficulty == 1)
        {
            if (status == "Excellent")
            {
                endDescription = "Under your superb leadership, the negative impacts of climate change and natural disasters were all minimised. This allowed Singapore to progress unhindered by natural disasters and climate change.";
            }
            else if (status == "Good")
            {
                endDescription = "Under your good leadership, the negative impacts of climate change and natural disasters were mostly minimised. Whilst your government could have done slightly better, it has done sufficiently well enough to win the approval of many more citizens.";
            }
            else if (status == "Average")
            {
                endDescription = "While your government did mitigate the impacts of certain disasters, it failed to resolve the impacts of some others. Hence, you are seen as an average leader who did his job fairly well but who could have done more.";
            }
            else if (status == "Unsuccessful")
            {
                endDescription = "As the COVID pandemic just ended, Singapore was expected to experience a slight ‘boom’. Thus, you are considered an unsuccessful leader as Singapore was held back by the negative impacts of climate change and natural disasters under your leadership.";
            }
        }

        else if (difficulty == 2)
        {
            if (status == "Excellent")
            {
                endDescription = "Under your superb leadership, the negative impacts of climate change, natural disasters and the World War were minimized. This allowed Singapore to progress unhindered whilst many other countries experienced setbacks. Because you never gave them up, let them down, or turned around, you have gained widespread approval from Singaporeans.";
            }
            else if (status == "Good")
            {
                endDescription = "Under your good leadership, the negative impacts of climate change, natural disasters, and the World War were signficantly reduced. Whilst your government could have done slightly better (and is not LKY-Tier), it has done sufficiently well enough to win the approval of many citizens.";
            }
            else if (status == "Average")
            {
                endDescription = "While your government did mitigate the impacts of certain disasters, it failed to resolve the impacts of some others. Hence, you are seen as an average leader who did alright but who could have done more.";
            }
            else if (status == "Unsuccessful")
            {
                endDescription = "Your government was mostly unable to mitigate the negative impacts of climate change, natural disasters, and the World War. This resulted in Singapore being very negatively impacted and caused many Singaporeans to lose their faith in your government.";
            }
        }

        else if (difficulty == 3)
        {
            if (status == "Excellent")
            {
                endDescription = "Under your superb leadership, the negative impacts of climate change, natural disasters and the Nuclear War were minimized. This allowed Singapore to progress unhindered whilst many other countries experienced setbacks and crises. Because you never gave them up, let them down, turned around, or deserted them, you have gained widespread approval from Singaporeans.";
            }
            else if (status == "Good")
            {
                endDescription = "Under your good leadership, the negative impacts of climate change, natural disasters, and the World War were signficantly reduced. Whilst your government could have done slightly better, it has done sufficiently well enough to win the approval of many citizens. As some have said of your government, 'They're a little confused but they got the spirit'.";
            }
            else if (status == "Average")
            {
                endDescription = "While your government did prevent Singaporeans from starving, it could have done more to mitigate the negative impacts of climate change, natural disasters, and the World War. Hence, you are seen as an average leader who did alright but who could have done more.";
            }
            else if (status == "Unsuccessful")
            {
                endDescription = "Your government was mostly unable to mitigate the negative impacts of climate change, natural disasters, and the World War. This resulted in Singapore being very negatively impacted and caused many Singaporeans to lose their faith in your government. Due to your government's inability to secure Singapore's food supply, many Singaporeans died of starvation, something not foreseen previously.";
            }
        }
	    enddescri.text = "Popularity: " + Convert.ToInt32(popularity) + "\nTasks completed: " + tasksCompleted + "\nTotal Score: " + (Convert.ToInt32(popularity) + tasksCompleted) + "\nStatus: " + status;
        endtxt.text = endDescription;
        
    } 
}
    