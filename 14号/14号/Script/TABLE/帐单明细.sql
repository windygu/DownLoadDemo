USE 酒店管理系统
GO
CREATE TABLE 帐单明细(
[帐单编号][CHAR](10) NOT NULL PRIMARY KEY,
[入住单号][CHAR](10) NOT NULL,
[客房编号][CHAR](10) NOT NULL,
[客房类型][CHAR](20) NULL,
[客房位置][CHAR](10) NULL,
[客房价格][DECIMAL] NULL,
[顾客姓名][CHAR](10) NULL,
[身份证][CHAR](20) NULL,
[消费内容][VARCHAR](40) NULL,
[消费金额][DECIMAL] NULL,
[入住时间][SMALLDATETIME] NULL,
[折扣][DECIMAL] NULL,
[结算日期][SMALLDATETIME] NULL,
[备注][VARCHAR](40) NULL
)
GO
