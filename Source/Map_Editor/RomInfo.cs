public class RomInfo
{
    public string game;
    public string lang;

    public RomInfo(string game, string lang)
    {
        this.game = game;
        this.lang = lang;
    }

    public static RomInfo FindById(int GameID)
    {
        switch (GameID)
        {
            case (0x45414441): return new RomInfo("diamond", "usa");
            case (0x45415041): return new RomInfo("pearl", "usa");
            case (0x53414441): return new RomInfo("diamond", "spa");
            case (0x53415041): return new RomInfo("pearl", "spa");
            case (0x46414441): return new RomInfo("diamond", "fra");
            case (0x46415041): return new RomInfo("pearl", "fra");
            case (0x49414441): return new RomInfo("diamond", "ita");
            case (0x49415041): return new RomInfo("pearl", "ita");
            case (0x44414441): return new RomInfo("diamond", "ger");
            case (0x44415041): return new RomInfo("pearl", "ger");
            case (0x4A414441): return new RomInfo("diamond", "jap");
            case (0x4A415041): return new RomInfo("pearl", "jap");
            case (0x4B414441): return new RomInfo("diamond", "kor");
            case (0x4B415041): return new RomInfo("pearl", "kor");

            case (0x45555043): return new RomInfo("platinum", "usa");
            case (0x53555043): return new RomInfo("platinum", "spa");
            case (0x46555043): return new RomInfo("platinum", "fra");
            case (0x49555043): return new RomInfo("platinum", "ita");
            case (0x44555043): return new RomInfo("platinum", "ger");
            case (0x4A555043): return new RomInfo("platinum", "jap");
            case (0x4B555043): return new RomInfo("platinum", "kor");

            case (0x454B5049): return new RomInfo("heartgold", "usa");
            case (0x45475049): return new RomInfo("soulsilver", "usa");
            case (0x534B5049): return new RomInfo("heartgold", "spa");
            case (0x53475049): return new RomInfo("soulsilver", "spa");
            case (0x464B5049): return new RomInfo("heartgold", "fra");
            case (0x46475049): return new RomInfo("soulsilver", "fra");
            case (0x494B5049): return new RomInfo("heartgold", "ita");
            case (0x49475049): return new RomInfo("soulsilver", "ita");
            case (0x444B5049): return new RomInfo("heartgold", "ger");
            case (0x44475049): return new RomInfo("soulsilver", "ger");
            case (0x4A4B5049): return new RomInfo("heartgold", "jap");
            case (0x4A475049): return new RomInfo("soulsilver", "jap");
            case (0x4B4B5049): return new RomInfo("heartgold", "kor");
            case (0x4B475049): return new RomInfo("soulsilver", "kor");
            
            case (0x4F425249): return new RomInfo("black", "usa");
            case (0x4F415249): return new RomInfo("platinum", "usa");
            case (0x53425249): return new RomInfo("black", "spa");
            case (0x53415249): return new RomInfo("platinum", "spa");
            case (0x46425249): return new RomInfo("black", "fra");
            case (0x46415249): return new RomInfo("platinum", "fra");
            case (0x49425249): return new RomInfo("black", "ita");
            case (0x49415249): return new RomInfo("platinum", "ita");
            case (0x44425249): return new RomInfo("black", "ger");
            case (0x44415249): return new RomInfo("platinum", "ger");
            case (0x4A425249): return new RomInfo("black", "jap");
            case (0x4A415249): return new RomInfo("platinum", "jap");
            case (0x4B425249): return new RomInfo("black", "kor");
            case (0x4B415249): return new RomInfo("platinum", "kor");
            
            case (0x4F455249): return new RomInfo("black2", "usa");
            case (0x4F445249): return new RomInfo("white2", "usa");
            case (0x53455249): return new RomInfo("black2", "spa");
            case (0x53445249): return new RomInfo("white2", "spa");
            case (0x46455249): return new RomInfo("black2", "fra");
            case (0x46445249): return new RomInfo("white2", "fra");
            case (0x49455249): return new RomInfo("black2", "ita");
            case (0x49445249): return new RomInfo("white2", "ita");
            case (0x44455249): return new RomInfo("black2", "ger");
            case (0x44445249): return new RomInfo("white2", "ger");
            case (0x4A455249): return new RomInfo("black2", "jap");
            case (0x4A445249): return new RomInfo("white2", "jap");
            case (0x4B455249): return new RomInfo("black2", "kor");
            case (0x4B445249): return new RomInfo("white2", "kor");
            default: return null;
        }

    }
}