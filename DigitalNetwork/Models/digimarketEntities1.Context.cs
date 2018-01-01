﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalNetwork.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class digimarketEntities1 : DbContext
    {
        public digimarketEntities1()
            : base("name=digimarketEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<DeletedArticle> DeletedArticles { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Rates_History> Rates_History { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Sites_Custom> Sites_Custom { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Articles> User_Articles { get; set; }
        public virtual DbSet<User_Date> User_Date { get; set; }
        public virtual DbSet<User_Marketing_Sources> User_Marketing_Sources { get; set; }
    
        public virtual int add_article(Nullable<int> aid, string article_url, Nullable<bool> status, string title, string summary, string photo_url, Nullable<System.DateTime> modified_date, string site_url, string category, string sub_category, Nullable<bool> custom)
        {
            var aidParameter = aid.HasValue ?
                new ObjectParameter("aid", aid) :
                new ObjectParameter("aid", typeof(int));
    
            var article_urlParameter = article_url != null ?
                new ObjectParameter("article_url", article_url) :
                new ObjectParameter("article_url", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(bool));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var summaryParameter = summary != null ?
                new ObjectParameter("summary", summary) :
                new ObjectParameter("summary", typeof(string));
    
            var photo_urlParameter = photo_url != null ?
                new ObjectParameter("photo_url", photo_url) :
                new ObjectParameter("photo_url", typeof(string));
    
            var modified_dateParameter = modified_date.HasValue ?
                new ObjectParameter("modified_date", modified_date) :
                new ObjectParameter("modified_date", typeof(System.DateTime));
    
            var site_urlParameter = site_url != null ?
                new ObjectParameter("site_url", site_url) :
                new ObjectParameter("site_url", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            var sub_categoryParameter = sub_category != null ?
                new ObjectParameter("sub_category", sub_category) :
                new ObjectParameter("sub_category", typeof(string));
    
            var customParameter = custom.HasValue ?
                new ObjectParameter("custom", custom) :
                new ObjectParameter("custom", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_article", aidParameter, article_urlParameter, statusParameter, titleParameter, summaryParameter, photo_urlParameter, modified_dateParameter, site_urlParameter, categoryParameter, sub_categoryParameter, customParameter);
        }
    
        public virtual int add_notification(string message, string category, string uid, Nullable<bool> status, Nullable<System.DateTime> date)
        {
            var messageParameter = message != null ?
                new ObjectParameter("message", message) :
                new ObjectParameter("message", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(bool));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_notification", messageParameter, categoryParameter, uidParameter, statusParameter, dateParameter);
        }
    
        public virtual int add_payment(string uid, Nullable<int> traffic, Nullable<decimal> amount, Nullable<System.DateTime> pay_date)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var trafficParameter = traffic.HasValue ?
                new ObjectParameter("traffic", traffic) :
                new ObjectParameter("traffic", typeof(int));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(decimal));
    
            var pay_dateParameter = pay_date.HasValue ?
                new ObjectParameter("pay_date", pay_date) :
                new ObjectParameter("pay_date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_payment", uidParameter, trafficParameter, amountParameter, pay_dateParameter);
        }
    
        public virtual int add_shared_article(string uid, Nullable<int> serial_no, Nullable<bool> copied, Nullable<bool> shared)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var serial_noParameter = serial_no.HasValue ?
                new ObjectParameter("serial_no", serial_no) :
                new ObjectParameter("serial_no", typeof(int));
    
            var copiedParameter = copied.HasValue ?
                new ObjectParameter("copied", copied) :
                new ObjectParameter("copied", typeof(bool));
    
            var sharedParameter = shared.HasValue ?
                new ObjectParameter("shared", shared) :
                new ObjectParameter("shared", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_shared_article", uidParameter, serial_noParameter, copiedParameter, sharedParameter);
        }
    
        public virtual int add_site(string site, string site_name, string gid, string email, Nullable<bool> custom)
        {
            var siteParameter = site != null ?
                new ObjectParameter("site", site) :
                new ObjectParameter("site", typeof(string));
    
            var site_nameParameter = site_name != null ?
                new ObjectParameter("site_name", site_name) :
                new ObjectParameter("site_name", typeof(string));
    
            var gidParameter = gid != null ?
                new ObjectParameter("gid", gid) :
                new ObjectParameter("gid", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var customParameter = custom.HasValue ?
                new ObjectParameter("custom", custom) :
                new ObjectParameter("custom", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_site", siteParameter, site_nameParameter, gidParameter, emailParameter, customParameter);
        }
    
        public virtual int add_ums(string ums_id, string uid, string url)
        {
            var ums_idParameter = ums_id != null ?
                new ObjectParameter("ums_id", ums_id) :
                new ObjectParameter("ums_id", typeof(string));
    
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_ums", ums_idParameter, uidParameter, urlParameter);
        }
    
        public virtual ObjectResult<admin_sign_in_Result> admin_sign_in(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<admin_sign_in_Result>("admin_sign_in", emailParameter);
        }
    
        public virtual int admin_sign_up(string email, string name, string photo)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("admin_sign_up", emailParameter, nameParameter, photoParameter);
        }
    
        public virtual int admin_update(string email, string name, string photo)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("admin_update", emailParameter, nameParameter, photoParameter);
        }
    
        public virtual int clear_payment(Nullable<int> invoiceid, string status, Nullable<System.DateTime> paydate)
        {
            var invoiceidParameter = invoiceid.HasValue ?
                new ObjectParameter("invoiceid", invoiceid) :
                new ObjectParameter("invoiceid", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var paydateParameter = paydate.HasValue ?
                new ObjectParameter("paydate", paydate) :
                new ObjectParameter("paydate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("clear_payment", invoiceidParameter, statusParameter, paydateParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> count_ums(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("count_ums", uidParameter);
        }
    
        public virtual int delete_article(Nullable<int> serial)
        {
            var serialParameter = serial.HasValue ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_article", serialParameter);
        }
    
        public virtual int delete_notification(Nullable<int> n_id)
        {
            var n_idParameter = n_id.HasValue ?
                new ObjectParameter("n_id", n_id) :
                new ObjectParameter("n_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_notification", n_idParameter);
        }
    
        public virtual int delete_site(string site_url, string email)
        {
            var site_urlParameter = site_url != null ?
                new ObjectParameter("site_url", site_url) :
                new ObjectParameter("site_url", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_site", site_urlParameter, emailParameter);
        }
    
        public virtual int delete_ums(string ums_id)
        {
            var ums_idParameter = ums_id != null ?
                new ObjectParameter("ums_id", ums_id) :
                new ObjectParameter("ums_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_ums", ums_idParameter);
        }
    
        public virtual ObjectResult<get_admin_articles_Result> get_admin_articles(string email, string site, Nullable<bool> status)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var siteParameter = site != null ?
                new ObjectParameter("site", site) :
                new ObjectParameter("site", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_admin_articles_Result>("get_admin_articles", emailParameter, siteParameter, statusParameter);
        }
    
        public virtual ObjectResult<get_admin_gid_Result> get_admin_gid(string site)
        {
            var siteParameter = site != null ?
                new ObjectParameter("site", site) :
                new ObjectParameter("site", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_admin_gid_Result>("get_admin_gid", siteParameter);
        }
    
        public virtual ObjectResult<get_admin_payments_Result> get_admin_payments(string status)
        {
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_admin_payments_Result>("get_admin_payments", statusParameter);
        }
    
        public virtual ObjectResult<get_admin_single_article_Result> get_admin_single_article(Nullable<int> aid, string email, string site)
        {
            var aidParameter = aid.HasValue ?
                new ObjectParameter("aid", aid) :
                new ObjectParameter("aid", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var siteParameter = site != null ?
                new ObjectParameter("site", site) :
                new ObjectParameter("site", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_admin_single_article_Result>("get_admin_single_article", aidParameter, emailParameter, siteParameter);
        }
    
        public virtual ObjectResult<get_adminPayments_Result> get_adminPayments(string status)
        {
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_adminPayments_Result>("get_adminPayments", statusParameter);
        }
    
        public virtual ObjectResult<get_all_articles_Result> get_all_articles(string site)
        {
            var siteParameter = site != null ?
                new ObjectParameter("site", site) :
                new ObjectParameter("site", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_all_articles_Result>("get_all_articles", siteParameter);
        }
    
        public virtual ObjectResult<get_all_site_Result> get_all_site()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_all_site_Result>("get_all_site");
        }
    
        public virtual ObjectResult<get_articles_Result> get_articles(string uid, string cat, string subcat)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var catParameter = cat != null ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(string));
    
            var subcatParameter = subcat != null ?
                new ObjectParameter("subcat", subcat) :
                new ObjectParameter("subcat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_articles_Result>("get_articles", uidParameter, catParameter, subcatParameter);
        }
    
        public virtual ObjectResult<get_deleted_articles_Result> get_deleted_articles(string email, string site)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var siteParameter = site != null ?
                new ObjectParameter("site", site) :
                new ObjectParameter("site", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_deleted_articles_Result>("get_deleted_articles", emailParameter, siteParameter);
        }
    
        public virtual ObjectResult<get_joining_date_Result> get_joining_date(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_joining_date_Result>("get_joining_date", uidParameter);
        }
    
        public virtual ObjectResult<get_notification_Result> get_notification()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_notification_Result>("get_notification");
        }
    
        public virtual ObjectResult<get_payment_Result> get_payment(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_payment_Result>("get_payment", uidParameter);
        }
    
        public virtual ObjectResult<get_pending_user_Result> get_pending_user()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_pending_user_Result>("get_pending_user");
        }
    
        public virtual ObjectResult<get_rate_Result> get_rate(string category)
        {
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_rate_Result>("get_rate", categoryParameter);
        }
    
        public virtual ObjectResult<get_shared_article_Result> get_shared_article(string uid, string cat, string subcat)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var catParameter = cat != null ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(string));
    
            var subcatParameter = subcat != null ?
                new ObjectParameter("subcat", subcat) :
                new ObjectParameter("subcat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_shared_article_Result>("get_shared_article", uidParameter, catParameter, subcatParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> get_shared_article_serial(Nullable<int> serial)
        {
            var serialParameter = serial.HasValue ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("get_shared_article_serial", serialParameter);
        }
    
        public virtual ObjectResult<get_site_Result> get_site(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_site_Result>("get_site", emailParameter);
        }
    
        public virtual ObjectResult<string> get_site_name(string url)
        {
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("get_site_name", urlParameter);
        }
    
        public virtual ObjectResult<get_total_earned_Result> get_total_earned(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_total_earned_Result>("get_total_earned", uidParameter);
        }
    
        public virtual ObjectResult<string> get_ums(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("get_ums", uidParameter);
        }
    
        public virtual ObjectResult<get_user_single_article_Result> get_user_single_article(Nullable<int> serial)
        {
            var serialParameter = serial.HasValue ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_user_single_article_Result>("get_user_single_article", serialParameter);
        }
    
        public virtual ObjectResult<get_user_sources_Result> get_user_sources(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_user_sources_Result>("get_user_sources", uidParameter);
        }
    
        public virtual ObjectResult<string> get_user_status(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("get_user_status", uidParameter);
        }
    
        public virtual ObjectResult<get_user_traffic_Result> get_user_traffic(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_user_traffic_Result>("get_user_traffic", uidParameter);
        }
    
        public virtual ObjectResult<getAllUser_Result> getAllUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllUser_Result>("getAllUser");
        }
    
        public virtual ObjectResult<getArticleBySerial_Result> getArticleBySerial(Nullable<int> serial)
        {
            var serialParameter = serial.HasValue ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getArticleBySerial_Result>("getArticleBySerial", serialParameter);
        }
    
        public virtual ObjectResult<Procedure_Result> Procedure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Procedure_Result>("Procedure");
        }
    
        public virtual int update_article_data(Nullable<int> serial_no, string article_url, string title, string summary, string photo_url, Nullable<System.DateTime> modified_date)
        {
            var serial_noParameter = serial_no.HasValue ?
                new ObjectParameter("serial_no", serial_no) :
                new ObjectParameter("serial_no", typeof(int));
    
            var article_urlParameter = article_url != null ?
                new ObjectParameter("article_url", article_url) :
                new ObjectParameter("article_url", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var summaryParameter = summary != null ?
                new ObjectParameter("summary", summary) :
                new ObjectParameter("summary", typeof(string));
    
            var photo_urlParameter = photo_url != null ?
                new ObjectParameter("photo_url", photo_url) :
                new ObjectParameter("photo_url", typeof(string));
    
            var modified_dateParameter = modified_date.HasValue ?
                new ObjectParameter("modified_date", modified_date) :
                new ObjectParameter("modified_date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_article_data", serial_noParameter, article_urlParameter, titleParameter, summaryParameter, photo_urlParameter, modified_dateParameter);
        }
    
        public virtual int update_articles(Nullable<bool> status, Nullable<int> serial, string cat, string subcat)
        {
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(bool));
    
            var serialParameter = serial.HasValue ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(int));
    
            var catParameter = cat != null ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(string));
    
            var subcatParameter = subcat != null ?
                new ObjectParameter("subcat", subcat) :
                new ObjectParameter("subcat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_articles", statusParameter, serialParameter, catParameter, subcatParameter);
        }
    
        public virtual int update_notification(string uid, Nullable<bool> status)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_notification", uidParameter, statusParameter);
        }
    
        public virtual int update_rates(string category, Nullable<decimal> rate, Nullable<System.DateTime> date)
        {
            var categoryParameter = category != null ?
                new ObjectParameter("category", category) :
                new ObjectParameter("category", typeof(string));
    
            var rateParameter = rate.HasValue ?
                new ObjectParameter("rate", rate) :
                new ObjectParameter("rate", typeof(decimal));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_rates", categoryParameter, rateParameter, dateParameter);
        }
    
        public virtual int update_shared_articles(string uid, Nullable<int> serial, Nullable<bool> shared, Nullable<bool> copied)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var serialParameter = serial.HasValue ?
                new ObjectParameter("serial", serial) :
                new ObjectParameter("serial", typeof(int));
    
            var sharedParameter = shared.HasValue ?
                new ObjectParameter("shared", shared) :
                new ObjectParameter("shared", typeof(bool));
    
            var copiedParameter = copied.HasValue ?
                new ObjectParameter("copied", copied) :
                new ObjectParameter("copied", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_shared_articles", uidParameter, serialParameter, sharedParameter, copiedParameter);
        }
    
        public virtual int update_site(string site_name, string site)
        {
            var site_nameParameter = site_name != null ?
                new ObjectParameter("site_name", site_name) :
                new ObjectParameter("site_name", typeof(string));
    
            var siteParameter = site != null ?
                new ObjectParameter("site", site) :
                new ObjectParameter("site", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_site", site_nameParameter, siteParameter);
        }
    
        public virtual ObjectResult<user_sign_in_Result> user_sign_in(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<user_sign_in_Result>("user_sign_in", uidParameter);
        }
    
        public virtual int user_sign_up(string uid, string name, string photo, string fullname, Nullable<System.DateTime> joindate)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(string));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("fullname", fullname) :
                new ObjectParameter("fullname", typeof(string));
    
            var joindateParameter = joindate.HasValue ?
                new ObjectParameter("joindate", joindate) :
                new ObjectParameter("joindate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("user_sign_up", uidParameter, nameParameter, photoParameter, fullnameParameter, joindateParameter);
        }
    
        public virtual int user_update(string uid, string status)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("user_update", uidParameter, statusParameter);
        }
    
        public virtual ObjectResult<string> get_uid(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("get_uid", usernameParameter);
        }
    }
}
