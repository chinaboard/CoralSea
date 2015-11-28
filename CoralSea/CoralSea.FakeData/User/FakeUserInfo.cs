using CoralSea.Common;
using CoralSea.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.FakeData.User
{
    public class FakeUserInfo : UserInfoModel
    {

        #region fake

        static List<string> _picurlList = new List<string>() { "http://img3.douban.com/icon/u48750150-75.jpg",
"http://img3.douban.com/icon/u137751255-1.jpg",
"http://img3.douban.com/icon/u61110940-5.jpg",
"http://img3.douban.com/icon/u122642569-3.jpg",
"http://img3.douban.com/icon/u40970571-2.jpg",
"http://img3.douban.com/icon/u97935041-12.jpg",
"http://img3.douban.com/icon/u138265730-1.jpg",
"http://img3.douban.com/icon/u54746565-4.jpg",
"http://img4.douban.com/icon/u53807409-6.jpg",
"http://img4.douban.com/icon/u84162221-8.jpg",
"http://img3.douban.com/icon/u55696089-21.jpg",
"http://img3.douban.com/icon/u33481086-25.jpg",
"http://img3.douban.com/icon/u124842466-5.jpg",
"http://img3.douban.com/icon/u50334755-4.jpg",
"http://img3.douban.com/icon/u51495232-10.jpg",
"http://img3.douban.com/icon/u136941262-2.jpg",
"http://img3.douban.com/icon/u61465631-21.jpg",
"http://img3.douban.com/icon/u33064327-10.jpg",
"http://img3.douban.com/icon/u72902788-1.jpg",
"http://img3.douban.com/icon/u88070849-3.jpg",
"http://img4.doubanio.com/icon/u55408389-9.jpg",
"http://img3.douban.com/icon/u130597398-2.jpg",
"http://img4.douban.com/icon/u125696802-17.jpg",
"http://img3.douban.com/icon/u60077520-5.jpg"};
        static string _maleName = "成德龙清宏弘圣戊嘉杰蒂胧特尼昊萨伟剑新杨森昆仑仓颉浑沌风峰智天空亚田野丸太郎潘高寿胜乾坤";
        static string _femaleName = "音芯伊唯郁绫妮美蔷薇佳玫瑰珠玑睿苍井空玛丽杏子樱桃颐畅春园妖娆裴沛宁珊姗晓红婷蕊楠慧琳川滨奈美堤莎也加町田梨乃二阶堂仁美饭岛爱饭田夏帆饭冢友子芳本叶月冈崎结由冈田丽奈高木萌美高田礼子高原流美宫本真美宫岛司古都光光月夜也河村亚季子河井梨绪黑崎扇菜红月流奈华歌恋吉川萌及川奈央吉川真奈美吉崎纱南吉野莎莉今井明日香今木翔子金泽蓝子进藤玲菜井上可奈久保美希酒井未希臼井利奈菊池丽香菊池英里菊池智子橘真央具志坚阳子可爱亚织沙葵小夏蓝山南兰望美里见奈奈子里美奈奈子里美由梨香立花丽华立木爱凉白舞铃川玲理铃江纹奈铃木麻奈美芦屋瞳麻川美绪麻生叶子美里霞美崎凉香美雪沙织美月莲明日香木谷麻耶奈奈见沙织内藤花苗内田理沙鲇川亚美片濑亚纪平山朝香前原优树前原佑子浅见伽椰浅井理青木琳青木玲青野诗织青羽未来青沼知朝秋本玲子秋菜里子秋元优奈如月可怜若林树里若月树里森下理音纱月结花杉浦清香杉山亚来山下由美子杉原凉子上原留华神城千佳神崎麻衣神崎麻子矢吹丽手束桃树本凉子水城凛水野朋美水野茜水越丽子四季彩香寺田弥生松浦梦松浦唯松田千夏松下爱来松下可怜松元静香速水真保藤彩香藤代流花藤崎秋藤森智子天衣美津田村麻衣望月瞳舞岛美织午后野弥生西泽友里夏美舞相川未希相户爱相田由美小仓杏小川流果筱宫知世小栗杏菜小森美王小室优奈小野由佳筱原凉小泽菜穗小泽玛丽亚筱冢真树子星爱丽斯星崎瞳星野绫香星野洋子星野真弥徐若樱雪乃小春岩下美季遥优衣野宫美忧野原奈津美叶月千穗伊东美华一色丽矢一色鲇美一条沙希乙伊沙也加樱井沙也加由树莉莉有川真生有吉奈生子有森玲香雨宫优衣原千寻原史奈原田春奈远野麻耶月野静玖早纪麻未早乙女舞泽舞音长濑爱长月亚美真木亚里沙真山润中川珠代中村理央中根由真中山美玖中原绫仲井美帆竹田树理佐伯美奈佐佐木幸田梨纱北原爱子成膳任戴文青木德永千奈美笛木优子福原爱高见美香高树玛丽亚宫崎葵观月雏乃海江田纯子后藤理莎后藤香南子矶山沙耶香矶山沙也加吉冈美穗吉泽瞳加纳则子加藤小雪菅谷梨沙子结城翼井上和香井上熏酒井瑛里久纱野水萌铃木爱理玲木美生泷泽乃南美依旗由美木下亚由美前田知惠前原爱浅田真央清水佐纪入江纱绫三尺真奈美三宅尚子森下千里上原绫石村舞波矢田亚希子市川由衣市井纱耶香嗣永桃子松岛菜菜子松居彩松元莉绪樋口真未细川直美夏烧雅相乐纪子小川熏小林惠美小野奈美小泽真珠星野亚希须藤茉麻亚纪奈岩田小百合伊藤步优香友崎玲中泽裕子佐藤麻纱安藤沙耶奥山唯子白崎令于柏木奈纯板谷佑滨田翔子朝雾唯川崎爱大和抚子大西由梨香岛田百合花二宫优绀野舞子岗原厚子高鸠阳子古河由摩谷田未央河合绫纯美和久井辛和希沙黑田美礼横仓里奈后藤亚维梨户田惠梨香吉濑美智子加藤麻依江纱绫井上诗织井上优香井真理绘堀井美月莲沼民子柳明日落合玲奈牧濑奈美木下亚由奈良沙绪理浅丘南秋本那夜秋山玲子秋庭比吕子三尺真奈三井保奈美森下真理山吹美花山口纱弥加杉里香神代弓子树梨沙水谷利加松鸠永里奈松山麻美松屿初音塔山直美藤香南子天使美树天野理惠田崎由希桐岛淳子尾崎美果西野美绪相泽优香小林里实小早川洋子叶山小姬樱树露衣樱田佳子永井绘理香远藤真纪早川美波早川桃香折原琴中鸠广香中泽夏木竹野内丰佐藤江梨花爱内萌爱田露美爱田毛毛安倍夏实安原真美奥山香八木泽白川美奈美白鸟智惠子白亚朱里北山静香北原步北原真裕仓本安奈仓田杏里朝比奈真理朝仓加穗里朝仓玛丽亚持田茜冲田由加里川奈由依大友梨奈岛田香奈堤沙也加渡边香风间舞风见京子福山洋子冈本夏生高仓梨奈高野瞳宫本瞳宫本阳子宫地奈宫间沙布子工藤瞳宫下杏菜河田纯子和希结衣横山千枝华美月姬野莉梦吉田友里吉野碧菅野美寿纪江口美贵结衣美沙金城美丽井上彩菜井上雅鸠村熏酒井美幸菊池则江君岛美香可爱亚芝莎来栖敦子蓝原夕妃蛯原舞立花优立原贵美恋野恋铃木由美麻生岬麻生真美子麻田子茂森亚弓美波志保木内亚吉拉内田京香品田由依平山绫前岛美步前田亚纪浅见怜浅野子青木美里清木裕子青山遥青山叶子三濑真美子三崎真绪三上夕希三尾安齐森宏子森山子森野雫山口理惠山口美纪山口萌杉山圭杉田惠美山田誉子杉原爱砂上原亚也加神崎美树神田美沙纪圣瑛麻石川恩惠石川瞳石川优季奈矢吹凉子矢吹麻理奈矢择优子水城梓水希遥松岛奈奈子松纱良速水怜藤井彩藤崎弭代田山真美子田中梨子田中美久瞳理欧望月七望月沙香望月英子武田真治夏结玲相纪美相乐晴子相仁泽美相原里奈翔巴辉小池亚弭小峰由衣筱宫庆子小田凉子小向杏奈小野濑幸田李梨岩崎千鹤野宫凛子野野由利加叶山路易一宫理绘伊藤美沙纪一条小百合樱庭凉子永井流奈优木里绪奈优木美纱羽田夕夏原惠美子远山雪乃远藤梨奈早濑理沙早乙女香织长谷川真纯麻子织原奈美柊丽子中条佳奈子中野美奈仲村桃足立美佐藤有纪八木亚希子朝比奈英里朝仓仁美朝仓香乃朝仓遥朝美光朝美绘乃香朝丘瞳朝霞佳绘美赤西凉川野亚希子大久保玲饭干惠子福光千穗冈田安希高以亚希子和久井由菜吉木纯菜吉泽京子井上华菜君野梦堀切子楠麻耶南使香平丸久美子青木友梨仁乃庆子三浦富美子山本京子榊彩弥矢野显子水野亚美水泽千夏太田优藤森子相崎琴音相泽纪美";
        static List<string> _groupName = new List<string>() { "旅游", "酒店", "游轮", "事业", "业务", "架构", "资源" };
        #endregion

        public FakeUserInfo(int id)
        {
            Id = id;
            JobNumber = RandomHelper.Next().ToString();
            Name = MakeFakeName();
            EntryTime = RandomHelper.Bool() ? DateTime.Now.Subtract(TimeSpan.FromDays(RandomHelper.Next(2000))) : DateTime.Now.Subtract(TimeSpan.FromHours(RandomHelper.Next(1000)));
            Rank = (int)DateTime.Now.Subtract(EntryTime).TotalDays * 2 + RandomHelper.Next(1000);
            Sex = RandomHelper.Bool() ? "男" : "女";
            LastLoginTime = DateTime.Now;
            NickName = MakeFakeName();
            GroupName = MakeFakeGroupName();
            Interesting.AddRange(new List<string>() { "耍帅", "睡觉", "撸代码" });
            Signature = "yooooooooooo";
            Image = _picurlList[RandomHelper.Next(_picurlList.Count)];
        }

        static string MakeFakeName()
        {
            var nameList = RandomHelper.Bool() ? _maleName.ToList() : _femaleName.ToList();
            var fakeName = string.Empty;
            for (int i = 0; i < 4; i++)
                fakeName += nameList[RandomHelper.Next(nameList.Count)];
            return fakeName;
        }
        static string MakeFakeGroupName()
        {
            var length = RandomHelper.Next(_groupName.Count);
            var groupName = string.Empty;
            for (int i = 0; i < length; i++)
                groupName += _groupName[RandomHelper.Next(_groupName.Count)] + "/";
            return groupName;
        }
    }
}
