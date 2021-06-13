﻿// <auto-generated />
using System;
using Blitz.Web.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Blitz.Web.Migrations
{
    [DbContext(typeof(BlitzDbContext))]
    [Migration("20210613113031_RoleTitleNonNullable")]
    partial class RoleTitleNonNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Blitz.Web.Cronjobs.Cronjob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Auth")
                        .HasColumnType("JSONB")
                        .HasColumnName("auth");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<string>("Cron")
                        .HasColumnType("text")
                        .HasColumnName("cron");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("Enabled")
                        .HasColumnType("boolean")
                        .HasColumnName("enabled");

                    b.Property<string>("HttpMethod")
                        .HasColumnType("text")
                        .HasColumnName("http_method");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("project_id");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Url")
                        .HasColumnType("text")
                        .HasColumnName("url");

                    b.HasKey("Id")
                        .HasName("pk_cronjobs");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("ix_cronjobs_created_at");

                    b.HasIndex("ProjectId")
                        .HasDatabaseName("ix_cronjobs_project_id");

                    b.ToTable("cronjobs");
                });

            modelBuilder.Entity("Blitz.Web.Cronjobs.Execution", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<Guid>("CronjobId")
                        .HasColumnType("uuid")
                        .HasColumnName("cronjob_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_executions");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("ix_executions_created_at");

                    b.HasIndex("CronjobId")
                        .HasDatabaseName("ix_executions_cronjob_id");

                    b.ToTable("executions");
                });

            modelBuilder.Entity("Blitz.Web.Cronjobs.ExecutionStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<string>("Details")
                        .HasColumnType("text")
                        .HasColumnName("details");

                    b.Property<Guid>("ExecutionId")
                        .HasColumnType("uuid")
                        .HasColumnName("execution_id");

                    b.Property<string>("State")
                        .HasColumnType("text")
                        .HasColumnName("state");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_status_updates");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("ix_status_updates_created_at");

                    b.HasIndex("ExecutionId")
                        .HasDatabaseName("ix_status_updates_execution_id");

                    b.ToTable("status_updates");
                });

            modelBuilder.Entity("Blitz.Web.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_roles_name");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Blitz.Web.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("IdProvider")
                        .HasColumnType("text")
                        .HasColumnName("id_provider");

                    b.Property<string>("IdProviderSub")
                        .HasColumnType("text")
                        .HasColumnName("id_provider_sub");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("ix_users_created_at");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_users_email");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Blitz.Web.Identity.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("claim_value");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_user_claims");

                    b.HasIndex("ClaimType")
                        .HasDatabaseName("ix_user_claims_claim_type");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_user_claims_user_id");

                    b.ToTable("user_claims");
                });

            modelBuilder.Entity("Blitz.Web.Projects.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Version")
                        .HasColumnType("text")
                        .HasColumnName("version");

                    b.HasKey("Id")
                        .HasName("pk_projects");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("ix_projects_created_at");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasDatabaseName("ix_projects_title");

                    b.HasIndex("Title", "Version")
                        .IsUnique()
                        .HasDatabaseName("ix_projects_title_version");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireCounter", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("ExpireAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("expire_at");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("key");

                    b.Property<long>("Value")
                        .HasColumnType("bigint")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_hangfire_counter");

                    b.HasIndex("ExpireAt")
                        .HasDatabaseName("ix_hangfire_counter_expire_at");

                    b.HasIndex("Key", "Value")
                        .HasDatabaseName("ix_hangfire_counter_key_value");

                    b.ToTable("hangfire_counter");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireHash", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("key");

                    b.Property<string>("Field")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("field");

                    b.Property<DateTime?>("ExpireAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("expire_at");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("Key", "Field")
                        .HasName("pk_hangfire_hash");

                    b.HasIndex("ExpireAt")
                        .HasDatabaseName("ix_hangfire_hash_expire_at");

                    b.ToTable("hangfire_hash");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireJob", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<DateTime?>("ExpireAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("expire_at");

                    b.Property<string>("InvocationData")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("invocation_data");

                    b.Property<long?>("StateId")
                        .HasColumnType("bigint")
                        .HasColumnName("state_id");

                    b.Property<string>("StateName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("state_name");

                    b.HasKey("Id")
                        .HasName("pk_hangfire_job");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("ix_hangfire_job_created_at");

                    b.HasIndex("ExpireAt")
                        .HasDatabaseName("ix_hangfire_job_expire_at");

                    b.HasIndex("StateId")
                        .HasDatabaseName("ix_hangfire_job_state_id");

                    b.HasIndex("StateName")
                        .HasDatabaseName("ix_hangfire_job_state_name");

                    b.ToTable("hangfire_job");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireJobParameter", b =>
                {
                    b.Property<long>("JobId")
                        .HasColumnType("bigint")
                        .HasColumnName("job_id");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("JobId", "Name")
                        .HasName("pk_hangfire_job_parameter");

                    b.ToTable("hangfire_job_parameter");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireList", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("key");

                    b.Property<int>("Position")
                        .HasColumnType("integer")
                        .HasColumnName("position");

                    b.Property<DateTime?>("ExpireAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("expire_at");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("Key", "Position")
                        .HasName("pk_hangfire_list");

                    b.HasIndex("ExpireAt")
                        .HasDatabaseName("ix_hangfire_list_expire_at");

                    b.ToTable("hangfire_list");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireLock", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("id");

                    b.Property<DateTime>("AcquiredAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("acquired_at");

                    b.HasKey("Id")
                        .HasName("pk_hangfire_lock");

                    b.ToTable("hangfire_lock");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireQueuedJob", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("FetchedAt")
                        .IsConcurrencyToken()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fetched_at");

                    b.Property<long>("JobId")
                        .HasColumnType("bigint")
                        .HasColumnName("job_id");

                    b.Property<string>("Queue")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("queue");

                    b.HasKey("Id")
                        .HasName("pk_hangfire_queued_job");

                    b.HasIndex("JobId")
                        .HasDatabaseName("ix_hangfire_queued_job_job_id");

                    b.HasIndex("Queue", "FetchedAt")
                        .HasDatabaseName("ix_hangfire_queued_job_queue_fetched_at");

                    b.ToTable("hangfire_queued_job");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireServer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("id");

                    b.Property<DateTime>("Heartbeat")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("heartbeat");

                    b.Property<string>("Queues")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("queues");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("started_at");

                    b.Property<int>("WorkerCount")
                        .HasColumnType("integer")
                        .HasColumnName("worker_count");

                    b.HasKey("Id")
                        .HasName("pk_hangfire_server");

                    b.HasIndex("Heartbeat")
                        .HasDatabaseName("ix_hangfire_server_heartbeat");

                    b.ToTable("hangfire_server");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireSet", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("key");

                    b.Property<string>("Value")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("value");

                    b.Property<DateTime?>("ExpireAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("expire_at");

                    b.Property<double>("Score")
                        .HasColumnType("double precision")
                        .HasColumnName("score");

                    b.HasKey("Key", "Value")
                        .HasName("pk_hangfire_set");

                    b.HasIndex("ExpireAt")
                        .HasDatabaseName("ix_hangfire_set_expire_at");

                    b.HasIndex("Key", "Score")
                        .HasDatabaseName("ix_hangfire_set_key_score");

                    b.ToTable("hangfire_set");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireState", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("current_timestamp");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("data");

                    b.Property<long>("JobId")
                        .HasColumnType("bigint")
                        .HasColumnName("job_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("Reason")
                        .HasColumnType("text")
                        .HasColumnName("reason");

                    b.HasKey("Id")
                        .HasName("pk_hangfire_state");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("ix_hangfire_state_created_at");

                    b.HasIndex("JobId")
                        .HasDatabaseName("ix_hangfire_state_job_id");

                    b.ToTable("hangfire_state");
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("role_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("RoleId", "UserId")
                        .HasName("pk_user_role");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_user_role_user_id");

                    b.ToTable("user_role");
                });

            modelBuilder.Entity("Blitz.Web.Cronjobs.Cronjob", b =>
                {
                    b.HasOne("Blitz.Web.Projects.Project", "Project")
                        .WithMany("Cronjobs")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("fk_cronjobs_projects_project_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Blitz.Web.Cronjobs.Execution", b =>
                {
                    b.HasOne("Blitz.Web.Cronjobs.Cronjob", "Cronjob")
                        .WithMany("Executions")
                        .HasForeignKey("CronjobId")
                        .HasConstraintName("fk_executions_cronjobs_cronjob_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cronjob");
                });

            modelBuilder.Entity("Blitz.Web.Cronjobs.ExecutionStatus", b =>
                {
                    b.HasOne("Blitz.Web.Cronjobs.Execution", "Execution")
                        .WithMany("Updates")
                        .HasForeignKey("ExecutionId")
                        .HasConstraintName("fk_status_updates_executions_execution_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Execution");
                });

            modelBuilder.Entity("Blitz.Web.Identity.UserClaim", b =>
                {
                    b.HasOne("Blitz.Web.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_claims_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireJob", b =>
                {
                    b.HasOne("Hangfire.EntityFrameworkCore.HangfireState", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .HasConstraintName("fk_hangfire_job_hangfire_state_state_id");

                    b.Navigation("State");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireJobParameter", b =>
                {
                    b.HasOne("Hangfire.EntityFrameworkCore.HangfireJob", "Job")
                        .WithMany("Parameters")
                        .HasForeignKey("JobId")
                        .HasConstraintName("fk_hangfire_job_parameter_hangfire_job_job_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireQueuedJob", b =>
                {
                    b.HasOne("Hangfire.EntityFrameworkCore.HangfireJob", "Job")
                        .WithMany("QueuedJobs")
                        .HasForeignKey("JobId")
                        .HasConstraintName("fk_hangfire_queued_job_hangfire_job_job_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireState", b =>
                {
                    b.HasOne("Hangfire.EntityFrameworkCore.HangfireJob", "Job")
                        .WithMany("States")
                        .HasForeignKey("JobId")
                        .HasConstraintName("fk_hangfire_state_hangfire_job_job_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.HasOne("Blitz.Web.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_user_role_roles_role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blitz.Web.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_role_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blitz.Web.Cronjobs.Cronjob", b =>
                {
                    b.Navigation("Executions");
                });

            modelBuilder.Entity("Blitz.Web.Cronjobs.Execution", b =>
                {
                    b.Navigation("Updates");
                });

            modelBuilder.Entity("Blitz.Web.Identity.User", b =>
                {
                    b.Navigation("Claims");
                });

            modelBuilder.Entity("Blitz.Web.Projects.Project", b =>
                {
                    b.Navigation("Cronjobs");
                });

            modelBuilder.Entity("Hangfire.EntityFrameworkCore.HangfireJob", b =>
                {
                    b.Navigation("Parameters");

                    b.Navigation("QueuedJobs");

                    b.Navigation("States");
                });
#pragma warning restore 612, 618
        }
    }
}
