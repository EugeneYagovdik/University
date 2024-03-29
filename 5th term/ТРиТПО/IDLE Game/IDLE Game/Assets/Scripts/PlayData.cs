using System;
using BreakInfinity;
using static BreakInfinity.BigDouble;

[Serializable]
public class PlayData
{
    public bool offlineProgressCheck;
    public BigDouble count;             //����� �����
    public BigDouble totalcount;
    public BigDouble ClickValue;        //������� ��� �������
    public BigDouble CU1Cost;           //��������� CU1
    public int CU1Level;          //������� CU1
    public BigDouble TU1Cost;           //������ �� ��������
    public int TU1Level;
    public BigDouble CU2Cost;
    public BigDouble CU2Power;          //����������� �������� ��� ��������� CU2
    public int CU2Level;
    public BigDouble TU2Cost;
    public BigDouble TU2Power;
    public int TU2Level;
    public BigDouble gems;              //���. ������
    public int gemsAvailable;     //����� ��������� � ������� gems
    public BigDouble CU1Max;            //max ���-�� ��������� � �������            //CU1 -- click upgrade 1
    public BigDouble CU2Max;                                                        //CU2 -- click upgrade 2
    public BigDouble TU1Max;                                                        //TU1 -- time upgrade 1
    public BigDouble TU2Max;                                                        //TU2 -- time upgrade 2

    public float AchLv1;
    public float AchLv2;

    public BigDouble eventTokens;
    public float[] eventCooldown = new float[2];
    public int eventActiveID;

    #region Prestige
    public int PUlevel1;
    public int PUlevel2;
    public int PUlevel3;
    #endregion

    public PlayData()
    {
        FullReset();
    }

    public void FullReset()
    {
        offlineProgressCheck = false;
        count = 0;
        totalcount = 0;
        ClickValue = 1;
        CU1Level = 0;
        TU1Level = 0;
        CU2Level = 0;
        TU2Level = 0;
        CU1Max = 0;
        TU1Max = 0;
        CU2Max = 0;
        TU2Max = 0;
        CU1Cost = 20;
        TU1Cost = 50;
        CU2Cost = 150;
        CU2Power = 5;
        TU2Cost = 250;
        TU2Power = 3;
        gems = 0;
        gemsAvailable = 0;

        AchLv1 = 0;
        AchLv2 = 0;

        PUlevel1 = 0;
        PUlevel2 = 0;
        PUlevel3 = 0;

        eventTokens = 0;
        for (var i = 0; i < eventCooldown.Length - 1; i++)
            eventCooldown[i] = 0;
        eventActiveID = 0;
    }
}