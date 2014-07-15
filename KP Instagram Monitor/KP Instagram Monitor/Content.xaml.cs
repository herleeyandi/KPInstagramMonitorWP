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
using System.IO.IsolatedStorage;
using System.Windows.Media.Imaging;

namespace KP_Instagram_Monitor
{
    public partial class Content : PhoneApplicationPage
    {
        public static String selfdata = "";
        public static String postdata = ""; 
        public String freshlike = "";
        public String freshcaption = "";
        public String freshimage = "";
        public String rewardMakan = "Reward Makan Gratis : \n";
        public String rewardMinum = "Reward Minum Gratis : \n";
        private readonly string apiAccessToken;

        
        public Content()
        {
            InitializeComponent();
            if (IsolatedStorageSettings.ApplicationSettings.Contains("access_token"))
            {
                this.apiAccessToken = IsolatedStorageSettings.ApplicationSettings["access_token"].ToString();
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            WebClient X = new WebClient();
            X.DownloadStringAsync(new Uri("https://api.instagram.com/v1/users/self?access_token=" + apiAccessToken));
            X.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DownloadStringCallback);
            WebClient Y = new WebClient();
            Y.DownloadStringAsync(new Uri("https://api.instagram.com/v1/users/self/media/recent?access_token=" + apiAccessToken));
            Y.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DownloadStringCallback2);
            System.Diagnostics.Debug.WriteLine(apiAccessToken);
            GetSelf();
            GetPost();
        }

        private static void DownloadStringCallback(Object sender, DownloadStringCompletedEventArgs e)
        {
            // If the request was not canceled and did not throw 
            // an exception, display the resource. 
            if (!e.Cancelled && e.Error == null)
            {
                selfdata = (string)e.Result;
            }
        }

        private static void DownloadStringCallback2(Object sender, DownloadStringCompletedEventArgs e)
        {
            // If the request was not canceled and did not throw 
            // an exception, display the resource. 
            if (!e.Cancelled && e.Error == null)
            {
                postdata = (string)e.Result;
            }
        }

        private void GetSelf()
        {
            String selfdata2 = selfdata;
            System.Diagnostics.Debug.WriteLine(selfdata2);
            StringBuilder temp = new StringBuilder(selfdata2);
            temp.Replace("{", "");
            temp.Replace("}", "");
            temp.Replace("\"", "<");
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
            temp.Replace("\\","");
            temp.Replace("Pofile Picture : ", "$");
            temp.Replace("Full Name : ", "$Full Name : ");
            String biodata = "";
            String linkfoto = "";
            String[] breakselfdata = temp.ToString().Split('$');
            foreach(String i in breakselfdata)
            {
                if (i.Contains("http"))
                    linkfoto = i;
                else
                    biodata = biodata + i;
            }
            System.Diagnostics.Debug.WriteLine(linkfoto);
            //IsolatedStorageSettings.ApplicationSettings["link_foto_diri"] = linkfoto;
           
            IsolatedStorageSettings.ApplicationSettings.Save();
            BitmapImage licoriceImage =new BitmapImage(new Uri(linkfoto, UriKind.RelativeOrAbsolute));
            selfphoto.Source = licoriceImage;
             
            datadiri.Text = biodata;

        } 

        private void GetPost()
        {
            String semuapost = "";
            String tempcomments = "";
            String templikes = "";
            String tempimages = "";
            String tempcaption = "";
            String postdata2 = postdata;
            System.Diagnostics.Debug.WriteLine(postdata2);
            StringBuilder temp = new StringBuilder(postdata2);
            temp.Replace("{", "");
            temp.Replace("}", "");
            temp.Replace("\"", "<");
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
            RefreshData();
        }
    }
}