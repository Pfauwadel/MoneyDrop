using Blueshift.EntityFrameworkCore.MongoDB.Annotations;
using Microsoft.EntityFrameworkCore;
using MoneyDrop.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyDrop.Repository
{
    [MongoDatabase("MoneyDrop")]
    public class MoneyDropDbContext : DbContext
    {
        public DbSet<Quizz> Quizzs { get; set; }

        public MoneyDropDbContext():this(new DbContextOptions<MoneyDropDbContext>())
        {

        }

        public MoneyDropDbContext(DbContextOptions<MoneyDropDbContext> moneyDropDbContextOptions) : base(moneyDropDbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "mongodb://mongoUser:mo_bdd67@cluster0-shard-00-00-hn1ea.mongodb.net:27017,cluster0-shard-00-01-hn1ea.mongodb.net:27017,cluster0-shard-00-02-hn1ea.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin";
            //optionsBuilder.UseMongoDb(connectionString);

            var mongoUrl = new MongoUrl(connectionString);
            //optionsBuilder.UseMongoDb(mongoUrl);

            MongoClientSettings settings = MongoClientSettings.FromUrl(mongoUrl);
            //settings.SslSettings = new SslSettings
            //{
            //    EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
            //};
            //optionsBuilder.UseMongoDb(settings);

            MongoClient mongoClient = new MongoClient(settings);
            optionsBuilder.UseMongoDb(mongoClient);
        }
    }
}
