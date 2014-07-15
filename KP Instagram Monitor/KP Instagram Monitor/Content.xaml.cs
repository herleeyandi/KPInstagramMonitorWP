using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Text;

namespace KP_Instagram_Monitor
{
    public partial class Content : PhoneApplicationPage
    {
        public String selfdata = "{<meta<:{<code<:200},<data<:{<username<:<herleeyandi<,<bio<:<Nothing<,<website<:<<,<profile_picture<:<http:://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<full_name<:<Herleeyandi Markoni<,<counts<:{<media<:3,<followed_by<:67,<follows<:569},<id<:<1418716729<}}";
        public String postdata = "{<pagination<:{},<meta<:{<code<:200},<data<:[{<attribution<:null,<tags<:[],<type<:<image<,<location<:null,<comments<:{<count<:0,<data<:[]},<filter<:<Normal<,<created_time<:<1405098373<,<link<:<http://instagram.com/p/qUYswzGwmd/<,<likes<:{<count<:5,<data<:[{<username<:<vinaarysthadewi<,<profile_picture<:<http://photos-d.ak.instagram.com/hphotos-ak-xfp1/10431862_303640103145395_804855832_a.jpg<,<id<:<398123328<,<full_name<:<Vina Arystha<},{<username<:<alvinlievedana_9021<,<profile_picture<:<http://photos-a.ak.instagram.com/hphotos-ak-xpa1/10483487_230343137175256_1350544426_a.jpg<,<id<:<940553674<,<full_name<:<Alvin Lie Vedanau00ae<},{<username<:<nyomanwidiyana<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xap1/10549641_1437292429867226_1237747226_a.jpg<,<id<:<25607860<,<full_name<:<I Nyoman Widiyana<},{<username<:<cayunaita<,<profile_picture<:<http://images.ak.instagram.com/profiles/profile_212934343_75sq_1398402298.jpg<,<id<:<212934343<,<full_name<:<Candra Yuni Aita<}]},<images<:{<low_resolution<:{<url<:<http://scontent-b.cdninstagram.com/hphotos-xfp1/t51.2885-15/10471888_488230307987018_1801831538_a.jpg<,<width<:306,<height<:306},<thumbnail<:{<url<:<http://scontent-b.cdninstagram.com/hphotos-xfp1/t51.2885-15/10471888_488230307987018_1801831538_s.jpg<,<width<:150,<height<:150},<standard_resolution<:{<url<:<http://scontent-b.cdninstagram.com/hphotos-xfp1/t51.2885-15/10471888_488230307987018_1801831538_n.jpg<,<width<:640,<height<:640}},<users_in_photo<:[],<caption<:{<created_time<:<1405098373<,<text<:<Saatnya coding ud83dude01<,<from<:{<username<:<herleeyandi<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<id<:<1418716729<,<full_name<:<Herleeyandi Markoni<},<id<:<762342866597644876<},<user_has_liked<:false,<id<:<762342866102716829_1418716729<,<user<:{<username<:<herleeyandi<,<website<:<<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<full_name<:<Herleeyandi Markoni<,<bio<:<<,<id<:<1418716729<}},{<attribution<:null,<tags<:[],<type<:<image<,<location<:null,<comments<:{<count<:7,<data<:[{<created_time<:<1404681057<,<text<:<Hha keren<,<from<:{<username<:<zuhriyansauqi<,<profile_picture<:<http://images.ak.instagram.com/profiles/profile_462170837_75sq_1373622508.jpg<,<id<:<462170837<,<full_name<:<Zuhriyan Sauqi<},<id<:<758842171286292547<},{<created_time<:<1404687808<,<text<:<Asik keren yan haha. Tulisan nokia di depan juga diganti donk ya?<,<from<:{<username<:<swhkn<,<profile_picture<:<http://photos-a.ak.instagram.com/hphotos-ak-xpf1/10261111_692873607444704_1993192415_a.jpg<,<id<:<46604024<,<full_name<:<swhkn<},<id<:<758898803936528976<},{<created_time<:<1404713934<,<text<:<Cieee punya insta cieeee<,<from<:{<username<:<yoza1404<,<profile_picture<:<http://images.ak.instagram.com/profiles/profile_173630189_75sq_1389780726.jpg<,<id<:<173630189<,<full_name<:<Adrianus Yoza  Aprilio<},<id<:<759117963811556157<},{<created_time<:<1404818449<,<text<:<@swhkn iya cuma belum saya foto.<,<from<:{<username<:<herleeyandi<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<id<:<1418716729<,<full_name<:<Herleeyandi Markoni<},<id<:<759994692021192832<},{<created_time<:<1404818468<,<text<:<@yoza1404  iya sih....<,<from<:{<username<:<herleeyandi<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<id<:<1418716729<,<full_name<:<Herleeyandi Markoni<},<id<:<759994857419376780<},{<created_time<:<1404822043<,<text<:<@swhkn foto depannya ada di profilku, @herleeyandi ayo nonton cak lenteng.<,<from<:{<username<:<yoza1404<,<profile_picture<:<http://images.ak.instagram.com/profiles/profile_173630189_75sq_1389780726.jpg<,<id<:<173630189<,<full_name<:<Adrianus Yoza  Aprilio<},<id<:<760024848462973204<},{<created_time<:<1404827563<,<text<:<@yoza1404 kp durung mari ud83dude10<,<from<:{<username<:<herleeyandi<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<id<:<1418716729<,<full_name<:<Herleeyandi Markoni<},<id<:<760071146817915249<}]},<filter<:<Normal<,<created_time<:<1404675899<,<link<:<http://instagram.com/p/qHy5TJmwn5/<,<likes<:{<count<:4,<data<:[{<username<:<swhkn<,<profile_picture<:<http://photos-a.ak.instagram.com/hphotos-ak-xpf1/10261111_692873607444704_1993192415_a.jpg<,<id<:<46604024<,<full_name<:<swhkn<},{<username<:<alvinlievedana_9021<,<profile_picture<:<http://photos-a.ak.instagram.com/hphotos-ak-xpa1/10483487_230343137175256_1350544426_a.jpg<,<id<:<940553674<,<full_name<:<Alvin Lie Vedanau00ae<},{<username<:<yoza1404<,<profile_picture<:<http://images.ak.instagram.com/profiles/profile_173630189_75sq_1389780726.jpg<,<id<:<173630189<,<full_name<:<Adrianus Yoza  Aprilio<},{<username<:<cayunaita<,<profile_picture<:<http://images.ak.instagram.com/profiles/profile_212934343_75sq_1398402298.jpg<,<id<:<212934343<,<full_name<:<Candra Yuni Aita<}]},<images<:{<low_resolution<:{<url<:<http://scontent-a.cdninstagram.com/hphotos-xpf1/t51.2885-15/10483529_1450010288587570_804268532_a.jpg<,<width<:306,<height<:306},<thumbnail<:{<url<:<http://scontent-a.cdninstagram.com/hphotos-xpf1/t51.2885-15/10483529_1450010288587570_804268532_s.jpg<,<width<:150,<height<:150},<standard_resolution<:{<url<:<http://scontent-a.cdninstagram.com/hphotos-xpf1/t51.2885-15/10483529_1450010288587570_804268532_n.jpg<,<width<:640,<height<:640}},<users_in_photo<:[],<caption<:{<created_time<:<1404675899<,<text<:<Say hello to Microsoft Mobility Lab ITS<,<from<:{<username<:<herleeyandi<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<id<:<1418716729<,<full_name<:<Herleeyandi Markoni<},<id<:<758798902712010869<},<user_has_liked<:false,<id<:<758798902133197305_1418716729<,<user<:{<username<:<herleeyandi<,<website<:<<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<full_name<:<Herleeyandi Markoni<,<bio<:<<,<id<:<1418716729<}},{<attribution<:null,<tags<:[],<type<:<image<,<location<:null,<comments<:{<count<:3,<data<:[{<created_time<:<1404804477<,<text<:<@herleeyandi keren kak andik, ajarkan saya kak hahaha<,<from<:{<username<:<ipungne<,<profile_picture<:<http://photos-d.ak.instagram.com/hphotos-ak-xpf1/10523525_658079507614587_103734143_a.jpg<,<id<:<459006019<,<full_name<:<pw<},<id<:<759877494132902587<},{<created_time<:<1404818384<,<text<:<@ipungne  ok<,<from<:{<username<:<herleeyandi<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<id<:<1418716729<,<full_name<:<Herleeyandi Markoni<},<id<:<759994146862336111<},{<created_time<:<1404818630<,<text<:<@ipungne tp ni lagi siap2 sambut windows phone 8.1<,<from<:{<username<:<herleeyandi<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<id<:<1418716729<,<full_name<:<Herleeyandi Markoni<},<id<:<759996213999896763<}]},<filter<:<Normal<,<created_time<:<1404674132<,<link<:<http://instagram.com/p/qHvhg6mwiJ/<,<likes<:{<count<:3,<data<:[{<username<:<fheragen<,<profile_picture<:<http://photos-f.ak.instagram.com/hphotos-ak-xap1/928293_433231063486629_1101988850_a.jpg<,<id<:<749671849<,<full_name<:<live is journey<},{<username<:<alvinlievedana_9021<,<profile_picture<:<http://photos-a.ak.instagram.com/hphotos-ak-xpa1/10483487_230343137175256_1350544426_a.jpg<,<id<:<940553674<,<full_name<:<Alvin Lie Vedanau00ae<},{<username<:<ipungne<,<profile_picture<:<http://photos-d.ak.instagram.com/hphotos-ak-xpf1/10523525_658079507614587_103734143_a.jpg<,<id<:<459006019<,<full_name<:<pw<}]},<images<:{<low_resolution<:{<url<:<http://scontent-a.cdninstagram.com/hphotos-xaf1/t51.2885-15/10499298_771812776196645_698647625_a.jpg<,<width<:306,<height<:306},<thumbnail<:{<url<:<http://scontent-a.cdninstagram.com/hphotos-xaf1/t51.2885-15/10499298_771812776196645_698647625_s.jpg<,<width<:150,<height<:150},<standard_resolution<:{<url<:<http://scontent-a.cdninstagram.com/hphotos-xaf1/t51.2885-15/10499298_771812776196645_698647625_n.jpg<,<width<:640,<height<:640}},<users_in_photo<:[],<caption<:null,<user_has_liked<:false,<id<:<758784073506949257_1418716729<,<user<:{<username<:<herleeyandi<,<website<:<<,<profile_picture<:<http://photos-c.ak.instagram.com/hphotos-ak-xpf1/10471918_690052684399994_553299805_a.jpg<,<full_name<:<Herleeyandi Markoni<,<bio<:<<,<id<:<1418716729<}}]}";
        public String freshlike = "";
        public String freshcaption = "";
        public String freshimage = "";
        public String rewardMakan = "Reward Makan Gratis : \n";
        public String rewardMinum = "Reward Minum Gratis : \n";

        
        public Content()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {

        }

        private void GetSelf()
        {
            selfdata.Replace('"', '<');
            StringBuilder temp = new StringBuilder(selfdata);
            temp.Replace("{", "");
            temp.Replace("}", "");
            temp.Replace("<,<", "\n");
            temp.Replace("<meta<:<code<:200,<data<:<", "");
            temp.Replace("username<:<", "Username : ");
            temp.Replace("bio<:<", "Bio : ");
            temp.Replace("website<:<", "Website : ");
            temp.Replace("profile_picture<:<", "Pofile Picture : ");
            temp.Replace("full_name<:<", "Full Name : ");
            temp.Replace("counts<:", "");
            temp.Replace("<media<:", "Media : ");
            temp.Replace(",<followed_by<:", "\nFollowed By : ");
            temp.Replace(",<follows<:", "\nFollows : ");
            temp.Replace(",<id<:<", "\nID :");
            temp.Replace("<", "");
            temp.Replace("http::", "http:");
            datadiri.Text = temp.ToString();

        } 

        private void GetPost()
        {
            String semuapost = "";
            String tempcomments = "";
            String templikes = "";
            String tempimages = "";
            String tempcaption = "";
            postdata.Replace('"', '<');
            StringBuilder temp = new StringBuilder(postdata);
            temp.Replace("{", "");
            temp.Replace("}", "");
            temp.Replace("<attribution<", "#");
            temp.Replace("<comments<:", "$<comments<:");
            temp.Replace("<likes<:", "$<likes<:");
            temp.Replace("<images<:", "$<images<:");
            temp.Replace("<caption<:", "$<caption<:");
            semuapost = temp.ToString();
            String[] arrsemuapost = semuapost.Split('#');
            foreach(String a in arrsemuapost)
            {
                String[] informasitiappost = a.Split('$');
                foreach(String b in informasitiappost)
                {
                    if (b.Contains("<comments<"))
                    {
                        tempcomments = tempcomments + b + "#";
                    }
                    else if(b.Contains("<likes<:"))
                    {
                        templikes = templikes + b + "#";
                    }
                    else if(b.Contains("<images<:"))
                    {
                        tempimages = tempimages + b + "#";
                    }
                    else if(b.Contains("<caption<:"))
                    {
                        tempcaption = tempcaption + b + "#";
                    }
                }
            }
            //System.Diagnostics.Debug.WriteLine("Comments : "+tempcomments);
            //System.Diagnostics.Debug.WriteLine("Likes : " + templikes);
            //System.Diagnostics.Debug.WriteLine("Images : " + tempimages);
            //System.Diagnostics.Debug.WriteLine("Caption : " + tempcaption);
            freshimage = MutateImages(tempimages);
            freshlike = MutateLike(templikes);
            freshcaption = MutateCaption(tempcaption);
            /*
            System.Diagnostics.Debug.WriteLine(freshimage);
            System.Diagnostics.Debug.WriteLine("======================================================================================");
            System.Diagnostics.Debug.WriteLine(freshcaption);
            System.Diagnostics.Debug.WriteLine("======================================================================================");
            System.Diagnostics.Debug.WriteLine(freshlike);
            System.Diagnostics.Debug.WriteLine("======================================================================================");
            */
            allpost.Text = ConcatePostDetail();
            liketeks.Text = GetLikeData();
            allreward.Text = rewardMakan + "\n" + rewardMinum;
        }

        private String MutateLike(String input)
        {
            String final = "";
            StringBuilder temp = new StringBuilder(input);
            temp.Replace("<,<", "\n");
            temp.Replace("username<:<", "\nUsername : ");
            temp.Replace("profile_picture<:<", "Pofile Picture : ");
            temp.Replace("full_name<:<", "Full Name : ");
            temp.Replace("id<:<", "ID :");
            temp.Replace("<],", "");
            temp.Replace("[", "");
            temp.Replace("],", "");
            temp.Replace("<data<:<", "$");
            temp.Replace("<likes", "$");
            String subfinal = temp.ToString();

            String[] correctlike = subfinal.Split('$');
            foreach(String a in correctlike)
            {
                if(a.Contains("Username"))
                {
                    final = final + a + "\n\n";
                }
            }
           
            return final;
        }

        private String MutateCaption(String input)
        {
            String final = "";
            StringBuilder temp = new StringBuilder(input);
            temp.Replace("<,<", "\n");
            temp.Replace("<created_time<:<", "Created Time : ");
            temp.Replace("text<:<", "Isi Post : ");
            temp.Replace("<caption<:", "$");
            temp.Replace(",<user_has_liked", "#$");
            temp.Replace("from<:", "#$");
            temp.Replace("[", "");
            temp.Replace("],", "");
            
            String subfinal = temp.ToString();

            String[] correctcaption = subfinal.Split('$');
            foreach (String a in correctcaption)
            {
                if (!a.Contains("username"))
                {
                    final = final + a ;
                }
            }
            return final;
        }

        private String MutateImages(String input)
        {
            String final = "";
            StringBuilder temp = new StringBuilder(input);
            temp.Replace("<,<width", "$");
            temp.Replace("<images<:<low_resolution<:<url<:<", "Link Gambar : ");
            temp.Replace("#", "$#");

            String subfinal = temp.ToString();

            String[] correctcaption = subfinal.Split('$');
            foreach (String a in correctcaption)
            {
                if (a.Contains("Link Gambar"))
                {
                    final = final + a;
                }
            }
            return final;
        }

        private String LikeJustUsername(String input)
        {
            String final = "";
            StringBuilder temp = new StringBuilder(input);
            temp.Replace("\n", "");
            temp.Replace("Pofile Picture", "$Pofile Picture");
            temp.Replace("Username : ", "$Username : ");
            temp.Replace("#", "$#");

            String subfinal = temp.ToString();

            String[] correctcaption = subfinal.Split('$');
            foreach (String a in correctcaption)
            {
                if (!a.Contains("Pofile Picture"))
                {
                    final = final + a;
                }
            }
            StringBuilder temp2 = new StringBuilder(final);
            temp2.Replace("Username : ", ",");
            temp2.Replace("#,", "#");
            final = temp2.ToString();
            return final;
        }

        private String ConcatePostDetail()
        {
            String final = "";
            String readylike = LikeJustUsername(freshlike);
            String[] perimages = freshimage.Split('#');
            String[] percaption = freshcaption.Split('#');
            String[] perlike = readylike.Split('#');
            int i;
            for (i = 0; i < perimages.Count(); i++ )
            {
                if(percaption[i]=="null")
                    final = final + percaption[i] + "\n" + perimages[i] + "\n Like : " + perlike[i] + "\n\n";
                else
                    final = final + percaption[i] + perimages[i] + "\n Like : " + perlike[i] + "\n\n";
            }
            StringBuilder temp = new StringBuilder(final);
            temp.Replace("Like : ," , "Like : ");
            final = temp.ToString();
            return final;
        }

        private String GetLikeData()
        {
            int count = 0;
            String final = "Data Like : \n";
            String subfinal = "";
            String readylike = LikeJustUsername(freshlike);
            StringBuilder temp = new StringBuilder(readylike);
            temp.Replace("#", ",");
            readylike = temp.ToString();
            String[] tiapusername = readylike.Split(',');
            foreach(String a in tiapusername)
            {
                if (a != "")
                {
                    if (!subfinal.Contains(a))
                    {
                        subfinal = subfinal + a +",";
                    }
                }
            }
            String[] cekuserlike = subfinal.Split(',');
            foreach(String b in cekuserlike)
            {
                count = 0;
                if (b != "")
                {
                    foreach (String c in tiapusername)
                    {
                        if (c.Contains(b))
                        {
                            count++;
                        }
                    }
                    if(count>2)
                    {
                        rewardMakan = rewardMakan + "-)"+ b + "\n";
                    }
                    else if(count<3)
                    {
                        rewardMinum = rewardMinum + "-)" + b + "\n";
                    }
                    final = final + "-)" + b + " " + count.ToString() + " likes\n";
                }
            } 
            return final;
        }

        private void loaddata_Click(object sender, RoutedEventArgs e)
        {
            GetSelf();
            GetPost();
        }
    }
}