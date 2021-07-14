// -----------------------------------------------------------------------------
// Generate By Furion Tools v2.12.3                            
// -----------------------------------------------------------------------------

using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using Admin.NET.EntityFramework.Core;

namespace Admin.NET.EntityFramework.Core
{
    public partial class videochannels : IEntity<MasterDbContextLocator>, IEntityTypeBuilder<videochannels, MasterDbContextLocator>
    {
    
        public long Id { get; set; }
        public string MainId { get; set; }
        public string MediaServerId { get; set; }
        public string Vhost { get; set; }
        public string App { get; set; }
        public string ChannelName { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string PDepartmentId { get; set; }
        public string PDepartmentName { get; set; }
        public string DeviceNetworkType { get; set; }
        public string DeviceStreamType { get; set; }
        public string MethodByGetStream { get; set; }
        public string VideoDeviceType { get; set; }
        public ulong AutoVideo { get; set; }
        public ulong AutoRecord { get; set; }
        public string RecordPlanName { get; set; }
        public string IpV4Address { get; set; }
        public string IpV6Address { get; set; }
        public ulong HasPtz { get; set; }
        public string DeviceId { get; set; }
        public string ChannelId { get; set; }
        public ulong? RtpWithTcp { get; set; }
        public string VideoSrcUrl { get; set; }
        public ulong? DefaultRtpPort { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public ulong? Enabled { get; set; }
        public ulong? NoPlayerBreak { get; set; }
        public string SpjkTZID { get; set; }
        public int? RecordSecs { get; set; }
    
        public void Configure(EntityTypeBuilder<videochannels> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
                entityBuilder.HasComment("����ͷͨ��ʵ��")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entityBuilder.HasIndex(e => e.ChannelName, "idx_vcs_chnn");

                entityBuilder.HasIndex(e => e.DepartmentId, "idx_vcs_dept");

                entityBuilder.HasIndex(e => e.Enabled, "idx_vcs_enbl");

                entityBuilder.HasIndex(e => e.IpV4Address, "idx_vcs_ipv4");

                entityBuilder.HasIndex(e => e.IpV6Address, "idx_vcs_ipv6");

                entityBuilder.HasIndex(e => e.MainId, "idx_vcs_maid")
                    .IsUnique();

                entityBuilder.HasIndex(e => e.MediaServerId, "idx_vcs_msid");

                entityBuilder.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasComment("���ݿ�����");

                entityBuilder.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasComment("app");

                entityBuilder.Property(e => e.AutoRecord)
                    .HasColumnType("bit(1)")
                    .HasComment("�Ƿ��Զ�����¼�Ƽƻ�");

                entityBuilder.Property(e => e.AutoVideo)
                    .HasColumnType("bit(1)")
                    .HasComment("�Ƿ��Զ�����������");

                entityBuilder.Property(e => e.ChannelId)
                    .HasMaxLength(20)
                    .HasComment("GB28181�豸��SipChannel.DeviceId");

                entityBuilder.Property(e => e.ChannelName)
                    .HasMaxLength(64)
                    .HasComment("ͨ�����ƣ�����ϵͳΨһ");

                entityBuilder.Property(e => e.CreateTime)
                    .HasColumnType("datetime(3)")
                    .HasComment("����ʱ��");

                entityBuilder.Property(e => e.DefaultRtpPort)
                    .HasColumnType("bit(1)")
                    .HasComment("Rtp�豸�Ƿ�ʹ����ý��Ĭ��rtp�˿ڣ���10000�˿�");

                entityBuilder.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .HasComment("���Ŵ���");

                entityBuilder.Property(e => e.DepartmentName)
                    .HasMaxLength(64)
                    .HasComment("��������");

                entityBuilder.Property(e => e.DeviceId)
                    .HasMaxLength(20)
                    .HasComment("GB28181�豸��SipDevice.DeviceId");

                entityBuilder.Property(e => e.DeviceNetworkType)
                    .HasMaxLength(255)
                    .HasComment("�豸����������");

                entityBuilder.Property(e => e.DeviceStreamType)
                    .HasMaxLength(255)
                    .HasComment("�豸��������");

                entityBuilder.Property(e => e.Enabled)
                    .HasColumnType("bit(1)")
                    .HasComment("�Ƿ�����");

                entityBuilder.Property(e => e.HasPtz)
                    .HasColumnType("bit(1)")
                    .HasComment("�豸�Ƿ�����̨����");

                entityBuilder.Property(e => e.IpV4Address)
                    .HasMaxLength(16)
                    .HasComment("�豸��ipv4��ַ");

                entityBuilder.Property(e => e.IpV6Address)
                    .HasMaxLength(64)
                    .HasComment("�豸��ipv6��ַ");

                entityBuilder.Property(e => e.MainId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasComment("�豸��ΨһID");

                entityBuilder.Property(e => e.MediaServerId)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasComment("��ý�������ID");

                entityBuilder.Property(e => e.MethodByGetStream)
                    .HasMaxLength(255)
                    .HasComment("ʹ�����ַ�ʽ��ȡ��rtp�豸����");

                entityBuilder.Property(e => e.NoPlayerBreak)
                    .HasColumnType("bit(1)")
                    .HasComment("���˹۲�ʱ�Ͽ����˿ڣ����ֶ�ΪtrueʱAutoVideo�ֶα���ΪFlase\n            ���AutoVideoΪtrue,����ֶ���Ч");

                entityBuilder.Property(e => e.PDepartmentId)
                    .HasMaxLength(20)
                    .HasComment("�ϼ����Ŵ���");

                entityBuilder.Property(e => e.PDepartmentName)
                    .HasMaxLength(64)
                    .HasComment("�ϼ���������");

                entityBuilder.Property(e => e.RecordPlanName)
                    .HasMaxLength(255)
                    .HasComment("¼�Ƽƻ�ģ������");

                entityBuilder.Property(e => e.RecordSecs)
                    .HasColumnType("int(11)")
                    .HasComment("¼��ʱ�����룩");

                entityBuilder.Property(e => e.RtpWithTcp)
                    .HasColumnType("bit(1)")
                    .HasComment("Rtp�豸�Ƿ�ʹ��Tcp����");

                entityBuilder.Property(e => e.SpjkTZID)
                    .HasMaxLength(255)
                    .HasComment("̨��ID");

                entityBuilder.Property(e => e.UpdateTime)
                    .HasColumnType("datetime(3)")
                    .HasComment("����ʱ��");

                entityBuilder.Property(e => e.Vhost)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasComment("vhost");

                entityBuilder.Property(e => e.VideoDeviceType)
                    .HasMaxLength(255)
                    .HasComment("�豸���ͣ�IPC,NVR,DVR");

                entityBuilder.Property(e => e.VideoSrcUrl)
                    .HasMaxLength(255)
                    .HasComment("��Rtp�豸����Ƶ��Դ��ַ");
        }

    }
}
