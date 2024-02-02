USE [master]
GO
/****** Object:  Database [bigbos_tradind]    Script Date: 02/02/2024 10:03:41 م ******/
CREATE DATABASE [bigbos_tradind]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bigbos_tradind', FILENAME = N'E:\bigbos_tradind.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bigbos_tradind_log', FILENAME = N'E:\bigbos_tradind_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bigbos_tradind] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bigbos_tradind].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bigbos_tradind] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bigbos_tradind] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bigbos_tradind] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bigbos_tradind] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bigbos_tradind] SET ARITHABORT OFF 
GO
ALTER DATABASE [bigbos_tradind] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bigbos_tradind] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bigbos_tradind] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bigbos_tradind] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bigbos_tradind] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bigbos_tradind] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bigbos_tradind] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bigbos_tradind] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bigbos_tradind] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bigbos_tradind] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bigbos_tradind] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bigbos_tradind] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bigbos_tradind] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bigbos_tradind] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bigbos_tradind] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bigbos_tradind] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bigbos_tradind] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bigbos_tradind] SET RECOVERY FULL 
GO
ALTER DATABASE [bigbos_tradind] SET  MULTI_USER 
GO
ALTER DATABASE [bigbos_tradind] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bigbos_tradind] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bigbos_tradind] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bigbos_tradind] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bigbos_tradind] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bigbos_tradind] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bigbos_tradind', N'ON'
GO
ALTER DATABASE [bigbos_tradind] SET QUERY_STORE = OFF
GO
USE [bigbos_tradind]
GO
/****** Object:  Table [dbo].[absentsandkhosomat]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[absentsandkhosomat](
	[order_id] [int] NOT NULL,
	[emp_id] [int] NULL,
	[emp_name] [nvarchar](50) NULL,
	[nomberof_days] [real] NULL,
	[type] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[notes] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[add_new_employee]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[add_new_employee](
	[emp_id] [int] NOT NULL,
	[emp_name] [nvarchar](50) NULL,
	[emp_salary] [real] NULL,
	[start_date] [nvarchar](50) NULL,
	[phone] [nvarchar](11) NULL,
	[national_id] [nvarchar](14) NULL,
	[address] [nvarchar](150) NULL,
	[activation] [bit] NULL,
 CONSTRAINT [PK_add_new_employee] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[addnew_users]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[addnew_users](
	[user_id] [int] NOT NULL,
	[user_name] [nvarchar](50) NULL,
	[user_password] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[stoke_id] [int] NULL,
	[reb7] [real] NULL,
	[branch_name] [nvarchar](100) NULL,
	[branch_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bank_insert]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bank_insert](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[bank_id] [int] NULL,
	[money] [real] NULL,
	[date] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[type] [nvarchar](250) NULL,
	[notes] [nvarchar](200) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
 CONSTRAINT [PK_bank_insert] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bank_money]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bank_money](
	[bank_id] [int] NULL,
	[money] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bank_withdrowal]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bank_withdrowal](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[bank_id] [int] NULL,
	[bank_money] [real] NULL,
	[money] [real] NULL,
	[date] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[type] [nvarchar](150) NULL,
	[notes] [nvarchar](50) NULL,
	[user_name] [nvarchar](150) NULL,
	[branch_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_bank_withdrowal] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bankes]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bankes](
	[bank_id] [int] NULL,
	[bank_name] [nvarchar](150) NULL,
	[notes] [nvarchar](350) NULL,
	[user_name] [nvarchar](150) NULL,
	[branch_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[branches]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branches](
	[branch_id] [int] NOT NULL,
	[branch_name] [nvarchar](150) NULL,
	[phone1] [nvarchar](50) NULL,
	[phone2] [nvarchar](50) NULL,
	[address] [nvarchar](450) NULL,
	[notes] [nvarchar](450) NULL,
	[gov] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[user_name] [nvarchar](150) NULL,
	[branche] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[buy]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buy](
	[order_id] [int] NOT NULL,
	[ezn_id] [int] NULL,
	[sup_id] [int] NULL,
	[date] [nvarchar](50) NULL,
	[user_name] [nvarchar](150) NULL,
	[discountontotalorder] [real] NULL,
	[totalorder] [real] NULL,
	[time] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[notes] [nvarchar](100) NULL,
	[mandoup_id] [int] NULL,
	[mandoup_name] [nvarchar](100) NULL,
	[store_id] [int] NULL,
	[items_count] [int] NULL,
	[store_name] [nvarchar](100) NULL,
 CONSTRAINT [PK_buy] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[buy_details]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buy_details](
	[order_id] [int] NOT NULL,
	[ezn_id] [int] NULL,
	[sup_id] [int] NULL,
	[product_id] [int] NULL,
	[Qty] [real] NULL,
	[date] [nvarchar](50) NULL,
	[user_name] [nvarchar](150) NULL,
	[price_before_tax] [real] NULL,
	[discount] [real] NULL,
	[discountontotalorder] [real] NULL,
	[total] [real] NULL,
	[totalorder] [real] NULL,
	[tax_value] [real] NULL,
	[price_tax] [real] NULL,
	[time] [nvarchar](50) NULL,
	[unit_name] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[notes_item] [nvarchar](100) NULL,
	[notes] [nvarchar](100) NULL,
	[mandoup_id] [int] NULL,
	[mandoup_name] [nvarchar](100) NULL,
	[row_number] [int] NULL,
	[store_id] [int] NULL,
	[items_count] [int] NULL,
	[store_name] [nvarchar](100) NULL,
	[pro_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[buy_details_money]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buy_details_money](
	[order_id] [int] NULL,
	[madfou3] [real] NULL,
	[branch_name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer_account]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer_account](
	[order_id] [int] NULL,
	[cust_id] [int] NULL,
	[cust_name] [nvarchar](150) NULL,
	[discription] [nvarchar](450) NULL,
	[pro_name] [nvarchar](150) NULL,
	[Qty] [real] NULL,
	[unit_name] [nvarchar](150) NULL,
	[total] [real] NULL,
	[totalorder] [real] NULL,
	[on_him] [real] NULL,
	[sadad] [real] NULL,
	[note_items] [nvarchar](450) NULL,
	[notes] [nvarchar](450) NULL,
	[user_name] [nvarchar](150) NULL,
	[branch_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[type] [nvarchar](250) NULL,
	[time] [nvarchar](50) NULL,
	[order_id2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[cust_id] [int] NOT NULL,
	[cust_name] [nvarchar](150) NULL,
	[phone] [nvarchar](50) NULL,
	[address] [nvarchar](350) NULL,
	[notes] [nvarchar](450) NULL,
	[identity_id] [int] NULL,
	[gov] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch] [nvarchar](50) NULL,
	[activation] [int] NULL,
 CONSTRAINT [PK_customers] PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[deserved]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deserved](
	[deserved_id] [int] NULL,
	[deserved_type_id] [int] NULL,
	[type_name] [nvarchar](150) NULL,
	[money] [real] NULL,
	[notes] [nvarchar](350) NULL,
	[date] [nvarchar](50) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch_name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[deserved_type]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deserved_type](
	[type_id] [int] NOT NULL,
	[type_name] [nvarchar](150) NULL,
	[notes] [nvarchar](150) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_deserved_type] PRIMARY KEY CLUSTERED 
(
	[type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_account]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_account](
	[order_id] [int] NULL,
	[emp_id] [int] NULL,
	[emp_name] [nvarchar](150) NULL,
	[discription] [nvarchar](450) NULL,
	[total] [real] NULL,
	[on_him] [real] NULL,
	[sadad] [real] NULL,
	[notes] [nvarchar](450) NULL,
	[user_name] [nvarchar](150) NULL,
	[branch_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[type] [nvarchar](250) NULL,
	[time] [nvarchar](50) NULL,
	[order_id2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[expenses_id]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[expenses_id](
	[id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[groups]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groups](
	[group_id] [int] NULL,
	[group_name] [nvarchar](220) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item_card]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_card](
	[pro_id] [int] NULL,
	[pro_name] [nvarchar](150) NULL,
	[store_id] [int] NULL,
	[store_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[unit_name] [nvarchar](50) NULL,
	[description] [nvarchar](250) NULL,
	[ward] [real] NULL,
	[monsarf] [real] NULL,
	[balance] [real] NULL,
	[user_name] [nvarchar](50) NULL,
	[branch_name] [nvarchar](50) NULL,
	[notes] [nvarchar](450) NULL,
	[order_id] [int] NULL,
	[type] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mandoup]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mandoup](
	[mandoup_id] [int] NULL,
	[mandoup_name] [nvarchar](250) NULL,
	[phone1] [nvarchar](50) NULL,
	[phone2] [nvarchar](50) NULL,
	[notes] [nvarchar](450) NULL,
	[gov] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[user_name] [nvarchar](150) NULL,
	[branch_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oldmoneyoncustomerandsupplier_id]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oldmoneyoncustomerandsupplier_id](
	[order_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_units]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_units](
	[pro_id] [int] NULL,
	[pro_name] [nvarchar](250) NULL,
	[unit_name] [nvarchar](150) NULL,
	[Qtyinunit] [real] NULL,
	[unitpricesales] [real] NULL,
	[unitpricecost] [real] NULL,
	[user_name] [nvarchar](150) NULL,
	[branch_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[product_id] [int] NOT NULL,
	[product_name] [nvarchar](100) NULL,
	[gomla_price] [real] NULL,
	[nosgomlaprice] [real] NULL,
	[sales_pricetagziaaa] [real] NULL,
	[tax_value] [real] NULL,
	[salesprice_tax_gomla] [real] NULL,
	[salesprice_tax_nosgomla] [real] NULL,
	[salesprice_tax_tagzaaaa] [real] NULL,
	[parcode] [nvarchar](200) NULL,
	[minQty] [real] NULL,
	[maxdiscount] [real] NULL,
	[is_tax] [nvarchar](50) NULL,
	[group_id] [int] NULL,
	[group_name] [nvarchar](50) NULL,
	[main_unitname] [nvarchar](50) NULL,
	[main_unitid] [int] NULL,
	[sales_unitname] [nvarchar](50) NULL,
	[sales_unit_id] [int] NULL,
	[buy_unitname] [nvarchar](50) NULL,
	[buy_unit_id] [int] NULL,
	[date] [nvarchar](50) NULL,
	[notes] [nvarchar](350) NULL,
	[sal7ia_date] [nvarchar](50) NULL,
	[countqtyinbigunit] [real] NULL,
	[countqtyinsmallunit] [real] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products_Qty]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products_Qty](
	[pro_id] [int] NULL,
	[pro_name] [nvarchar](150) NULL,
	[qty] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products_Qtyinstore]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products_Qtyinstore](
	[pro_id] [int] NOT NULL,
	[pro_name] [nvarchar](150) NULL,
	[Qty] [real] NULL,
	[store_id] [int] NULL,
	[store_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[return_details]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[return_details](
	[order_id] [int] NOT NULL,
	[sup_id] [int] NULL,
	[product_id] [int] NULL,
	[Qty] [real] NULL,
	[date] [nvarchar](50) NULL,
	[user_name] [nvarchar](150) NULL,
	[price_before_tax] [real] NULL,
	[discount] [real] NULL,
	[discountontotalorder] [real] NULL,
	[total] [real] NULL,
	[totalorder] [real] NULL,
	[tax_value] [real] NULL,
	[price_tax] [real] NULL,
	[time] [nvarchar](50) NULL,
	[unit_name] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[notes_item] [nvarchar](100) NULL,
	[notes] [nvarchar](100) NULL,
	[row_number] [int] NULL,
	[store_id] [int] NULL,
	[items_count] [int] NULL,
	[store_name] [nvarchar](100) NULL,
	[pro_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[return_details_sales]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[return_details_sales](
	[order_id] [int] NOT NULL,
	[cust_id] [int] NULL,
	[product_id] [int] NULL,
	[Qty] [real] NULL,
	[date] [nvarchar](50) NULL,
	[user_name] [nvarchar](150) NULL,
	[price_before_tax] [real] NULL,
	[discount] [real] NULL,
	[discountontotalorder] [real] NULL,
	[total] [real] NULL,
	[totalorder] [real] NULL,
	[tax_value] [real] NULL,
	[price_tax] [real] NULL,
	[time] [nvarchar](50) NULL,
	[unit_name] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[notes_item] [nvarchar](100) NULL,
	[notes] [nvarchar](100) NULL,
	[row_number] [int] NULL,
	[store_id] [int] NULL,
	[items_count] [int] NULL,
	[store_name] [nvarchar](100) NULL,
	[pro_name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[returns]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[returns](
	[order_id] [int] NOT NULL,
	[sup_id] [int] NULL,
	[date] [nvarchar](50) NULL,
	[user_name] [nvarchar](150) NULL,
	[discountontotalorder] [real] NULL,
	[totalorder] [real] NULL,
	[time] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[notes] [nvarchar](100) NULL,
	[store_id] [int] NULL,
	[items_count] [int] NULL,
	[store_name] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[returns_sales]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[returns_sales](
	[order_id] [int] NOT NULL,
	[cust_id] [int] NULL,
	[date] [nvarchar](50) NULL,
	[user_name] [nvarchar](150) NULL,
	[discountontotalorder] [real] NULL,
	[totalorder] [real] NULL,
	[time] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[notes] [nvarchar](100) NULL,
	[store_id] [int] NULL,
	[items_count] [int] NULL,
	[store_name] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[order_id] [int] NOT NULL,
	[order_ezn] [int] NULL,
	[cust_id] [int] NULL,
	[discountonallorder] [real] NULL,
	[totalorder] [real] NULL,
	[tax_value] [real] NULL,
	[user_name] [nvarchar](50) NULL,
	[time] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[notes] [nvarchar](550) NULL,
	[store_name] [nvarchar](150) NULL,
	[store_id] [int] NULL,
	[mandoup_id] [int] NULL,
	[mandoup_name] [nvarchar](150) NULL,
	[billfor] [nvarchar](100) NULL,
	[countofitems] [int] NULL,
 CONSTRAINT [PK_sales] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales_details]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales_details](
	[order_id] [int] NOT NULL,
	[order_ezn] [int] NULL,
	[pro_id] [int] NULL,
	[pro_name] [nvarchar](150) NULL,
	[cust_id] [int] NULL,
	[Qty] [real] NULL,
	[price] [real] NULL,
	[discount] [real] NULL,
	[discountonallorder] [real] NULL,
	[total] [real] NULL,
	[totalorder] [real] NULL,
	[unit] [nvarchar](50) NULL,
	[tax_value] [real] NULL,
	[price_tax] [real] NULL,
	[user_name] [nvarchar](50) NULL,
	[time] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[notes_item] [nvarchar](450) NULL,
	[notes] [nvarchar](550) NULL,
	[row_number] [real] NULL,
	[store_name] [nvarchar](150) NULL,
	[store_id] [int] NULL,
	[mandoup_id] [int] NULL,
	[mandoup_name] [nvarchar](150) NULL,
	[billfor] [nvarchar](100) NULL,
	[countofitems] [int] NULL,
	[qtyavalibalenow] [real] NULL,
	[cost_price] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales_details_money]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales_details_money](
	[order_id] [int] NOT NULL,
	[person_name] [nvarchar](150) NULL,
	[madfou3] [real] NULL,
	[totalonhim] [real] NULL,
	[billfor] [nvarchar](50) NULL,
	[branch_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_sales_details_money] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sand_kabd]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sand_kabd](
	[order_id] [int] NOT NULL,
	[type] [nvarchar](50) NULL,
	[person_id] [int] NULL,
	[person_name] [nvarchar](150) NULL,
	[money] [real] NULL,
	[date] [nvarchar](50) NULL,
	[notes] [nvarchar](250) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch] [nvarchar](50) NULL,
	[time] [nvarchar](50) NULL,
 CONSTRAINT [PK_sand_kabd] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sand_sarf]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sand_sarf](
	[order_id] [int] NOT NULL,
	[type] [nvarchar](50) NULL,
	[person_id] [int] NULL,
	[person_name] [nvarchar](150) NULL,
	[money] [real] NULL,
	[date] [nvarchar](50) NULL,
	[notes] [nvarchar](250) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch] [nvarchar](50) NULL,
 CONSTRAINT [PK_sand_sarf] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sandat_deleted]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sandat_deleted](
	[order_id] [int] NULL,
	[person_name] [nvarchar](150) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch] [nvarchar](50) NULL,
	[money] [real] NULL,
	[type] [nvarchar](50) NULL,
	[type2] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sandat_id]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sandat_id](
	[sand_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[settingprinting_bills]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[settingprinting_bills](
	[logo] [image] NULL,
	[name] [nvarchar](150) NULL,
	[address] [nvarchar](250) NULL,
	[discription] [nvarchar](450) NULL,
	[phone1] [nvarchar](50) NULL,
	[phone2] [nvarchar](50) NULL,
	[phone3] [nvarchar](50) NULL,
	[tax_re] [nvarchar](250) NULL,
	[commerical_re] [nvarchar](250) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stoke_andbank_transfere]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stoke_andbank_transfere](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[transfrom] [int] NULL,
	[transto] [int] NULL,
	[money] [real] NULL,
	[date] [nvarchar](150) NULL,
	[type] [nvarchar](150) NULL,
	[notes] [nvarchar](350) NULL,
	[name] [nvarchar](250) NULL,
	[user_name] [nvarchar](150) NULL,
	[branch_name] [nvarchar](150) NULL,
	[typeoperation] [nvarchar](50) NULL,
	[transnumber] [int] NULL,
 CONSTRAINT [PK_stoke_andbank_transfere] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stoke_insert]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stoke_insert](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[stoke_id] [int] NULL,
	[money] [real] NULL,
	[date] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[type] [nvarchar](250) NULL,
	[notes] [nvarchar](200) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch_name] [nvarchar](100) NULL,
	[order_id2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stoke_money]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stoke_money](
	[stoke_id] [int] NULL,
	[money] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stoke_withdrowal]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stoke_withdrowal](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[stoke_id] [int] NULL,
	[money] [real] NULL,
	[date] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[type] [nvarchar](250) NULL,
	[notes] [nvarchar](200) NULL,
	[user_name] [nvarchar](200) NULL,
	[branch_name] [nvarchar](100) NULL,
	[order_id2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stokes]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stokes](
	[stoke_id] [int] NOT NULL,
	[stoke_name] [nvarchar](150) NULL,
	[user_name] [nvarchar](150) NULL,
	[branch_name] [nvarchar](150) NULL,
	[notes] [nvarchar](350) NULL,
	[date] [nvarchar](50) NULL,
 CONSTRAINT [PK_stokes] PRIMARY KEY CLUSTERED 
(
	[stoke_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stores]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stores](
	[store_id] [int] NULL,
	[store_name] [nvarchar](350) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier_account]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier_account](
	[order_id] [int] NULL,
	[sup_id] [int] NULL,
	[sup_name] [nvarchar](150) NULL,
	[description] [nvarchar](350) NULL,
	[pro_name] [nvarchar](150) NULL,
	[Qty] [real] NULL,
	[total] [real] NULL,
	[totalorder] [real] NULL,
	[notes] [nvarchar](250) NULL,
	[leh] [real] NULL,
	[sadad] [real] NULL,
	[balance] [real] NULL,
	[user_name] [nvarchar](150) NULL,
	[branch_name] [nvarchar](150) NULL,
	[date] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[unit] [nvarchar](50) NULL,
	[order_id2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliers](
	[sup_id] [int] NOT NULL,
	[sup_name] [nvarchar](150) NULL,
	[phone] [nvarchar](50) NULL,
	[address] [nvarchar](350) NULL,
	[notes] [nvarchar](450) NULL,
	[identity_id] [int] NULL,
	[gov] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch] [nvarchar](50) NULL,
 CONSTRAINT [PK_suppliers] PRIMARY KEY CLUSTERED 
(
	[sup_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transferebetweenstokes]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transferebetweenstokes](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[stokefrom_id] [int] NULL,
	[stokefrom_name] [nvarchar](50) NULL,
	[money] [real] NULL,
	[stoketo_id] [int] NULL,
	[stoketo_name] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[row_nomber] [int] NULL,
	[note_row] [nvarchar](250) NULL,
	[notes] [nvarchar](350) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_transferebetweenstokes] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transferefrombanktobank]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transferefrombanktobank](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[bankfrom_id] [int] NULL,
	[bankfrom_name] [nvarchar](150) NULL,
	[bankto_id] [int] NULL,
	[bankto_name] [nvarchar](150) NULL,
	[money] [real] NULL,
	[date] [nvarchar](50) NULL,
	[name] [nvarchar](150) NULL,
	[notes] [nvarchar](450) NULL,
	[user_name] [nvarchar](100) NULL,
	[branch_name] [nvarchar](100) NULL,
	[type] [nvarchar](50) NULL,
 CONSTRAINT [PK_transferefrombanktobank] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transfereproductsbetweenstores]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transfereproductsbetweenstores](
	[order_id] [int] NULL,
	[ezn_number] [int] NULL,
	[pro_id] [int] NULL,
	[pro_name] [nvarchar](250) NULL,
	[Qty] [real] NULL,
	[unit] [nvarchar](50) NULL,
	[store_id_from] [int] NULL,
	[store_name_from] [nvarchar](150) NULL,
	[store_id_to] [int] NULL,
	[store_name_to] [nvarchar](150) NULL,
	[note_item] [nvarchar](150) NULL,
	[notes] [nvarchar](350) NULL,
	[row_number] [int] NULL,
	[date] [nvarchar](50) NULL,
	[user_name] [nvarchar](50) NULL,
	[branch_name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[units]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[units](
	[unit_id] [int] NULL,
	[unit_name] [nvarchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[buy_print]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buy_print]
As
--طباعه المشتريات A4



select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'تليفون1',settingprinting_bills.phone2 as'تليفون2',settingprinting_bills.phone3 as'تليفون3',settingprinting_bills.commerical_re as'الرقم التجاري',settingprinting_bills.tax_re as'الرقم الضريبي',buy_details.order_id as'رقم الفاتوره',ezn_id as'رقم الاذن',suppliers.sup_name as'اسم المورد',products.product_name as'المنتج',buy_details.Qty as'الكميه',buy_details.date as'التاريخ',buy_details.user_name as'المستخدم',buy_details.price_tax as'المبلغ',buy_details.discountontotalorder as'الخصم الكلي',buy_details.total as'الاجمالي',buy_details.totalorder as'الاجمالي الكلي',buy_details.unit_name as'الوحده',buy_details.type as'نوع الفاتوره',buy_details.branch_name as'الفرع',buy_details.notes_item as'ملاحظه صنف',buy_details.notes as'ملاحظات عامه',buy_details.mandoup_name as'المندوب',buy_details.store_name as'المخزن',buy_details_money.madfou3 as 'المدفوغ'  from buy_details,suppliers,settingprinting_bills,products,buy_details_money where buy_details.product_id=products.product_id and suppliers.sup_id=buy_details.sup_id and buy_details.order_id=buy_details_money.order_id 
GO
/****** Object:  StoredProcedure [dbo].[customer_account_print]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[customer_account_print]
As
--طباعه كشف حساب عميل A4



select settingprinting_bills.logo as 'اللوجو',settingprinting_bills.name as 'اسم الشركه',settingprinting_bills.address as 'العنوان',settingprinting_bills.discription as 'جمله',settingprinting_bills.phone1 as 'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as 'فون3',settingprinting_bills.commerical_re as 'الرقم التجاري',settingprinting_bills.tax_re as 'الرقم الضريبي',order_id as 'رقم البيان',cust_id as 'رقم العميل',cust_name as 'اسم العميل',customer_account.discription as 'البيان',pro_name as 'الصنف',Qty as'الكميه', unit_name as 'الوحده',total as'الاجمالي', totalorder as'الاجمالي الكلي',on_him as'عليه',sadad as 'السداد',note_items as'ملاحظه صنف',notes as 'ملاحظات عامه',user_name as 'المستخدم',branch_name as'الفرع',date as'التاريخ' from customer_account,settingprinting_bills order by date
GO
/****** Object:  StoredProcedure [dbo].[sales_printA4]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sales_printA4]
As
--طباعه فاتوره مبيعات A4



select settingprinting_bills.logo as 'اللوجو',settingprinting_bills.name as 'اسم الشركه',settingprinting_bills.address as 'العنوان',settingprinting_bills.phone1 as 'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',settingprinting_bills.discription as 'الوصف',settingprinting_bills.commerical_re as'السجل التجاري',settingprinting_bills.tax_re as'التسجيل الضريبي', sales_details.order_id as 'رقم الفاتوره',order_ezn as 'رقم الاذن',pro_name as 'اسم المنتج',Qty as 'الكميه',price_tax as 'السعر',discountonallorder as 'الخصم الكلي',total as 'الاجمالي',totalorder as 'الاجمالي الكلي',unit as 'الوحده',time as 'الوقت',sales_details.user_name as 'المستخدم',sales_details.branch_name as 'الفرع',sales_details.date as 'التاريخ',type as 'نوع الاوردر',notes_item as 'ملاحظه صنف',sales_details.notes as 'ملاحظه عامه', store_name as 'المخزن',mandoup_name as 'المندوب',sales_details.billfor as 'فاتوره ل',sales_details_money.madfou3 as'المدفوع',sales_details_money.person_name as 'اسم الشخص',sales_details_money.totalonhim as 'اجمالي اللي علي الشخص',sales_details_money.branch_name as 'الفرع في الجدول التاني sales_money' from sales_details,settingprinting_bills,sales_details_money where   sales_details.order_id=sales_details_money.order_id 
GO
/****** Object:  StoredProcedure [dbo].[sand_kabd_print]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sand_kabd_print]
As
--طباعه سند قبض A4



select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'تليفون1',settingprinting_bills.phone2 as'تليفون2',settingprinting_bills.phone3 as'تليفون3',settingprinting_bills.commerical_re as'الرقم التجاري',settingprinting_bills.tax_re as'الرقم الضريبي',order_id as 'رقم السند',type as 'نوع السند',person_name as'اسم الشخص',money as'المبلغ',date as'التاريخ',notes as'ملاحظات',user_name as'المستخدم',branch as'الفرع' from sand_kabd,settingprinting_bills
GO
/****** Object:  StoredProcedure [dbo].[sand_sarf_print]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sand_sarf_print]
As
--طباعه سند صرف A4



select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'تليفون1',settingprinting_bills.phone2 as'تليفون2',settingprinting_bills.phone3 as'تليفون3',settingprinting_bills.commerical_re as'الرقم التجاري',settingprinting_bills.tax_re as'الرقم الضريبي',order_id as 'رقم السند',type as 'نوع السند',person_name as'اسم الشخص',money as'المبلغ',date as'التاريخ',notes as'ملاحظات',user_name as'المستخدم',branch as'الفرع' from sand_sarf,settingprinting_bills
GO
/****** Object:  StoredProcedure [dbo].[supplier_account_printA4]    Script Date: 02/02/2024 10:03:41 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[supplier_account_printA4]
As
--طباعه كشف حساب مورد A4



select settingprinting_bills.logo as 'اللوجو',settingprinting_bills.name as 'اسم الشركه',settingprinting_bills.address as 'العنوان',settingprinting_bills.phone1 as 'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',settingprinting_bills.discription as 'الوصف',settingprinting_bills.commerical_re as'السجل التجاري',settingprinting_bills.tax_re as'التسجيل الضريبي', order_id as'رقم البيان',sup_id as'رقم المورد',sup_name as'اسم المورد',supplier_account.description as'البيان',pro_name as'الصنف',Qty as'الكميه',total as'الاجمالي',totalorder as'الاجمالي الكلي',notes as'ملاحظات',leh as'ليه',sadad as'السداد',user_name as'المستخدم',branch_name as'الفرع',date as'التاريخ',type as'نوع العمليه',unit as'الوحده' from supplier_account,settingprinting_bills
GO
USE [master]
GO
ALTER DATABASE [bigbos_tradind] SET  READ_WRITE 
GO
