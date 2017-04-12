CREATE TABLE Clerk(
    ClID          nvarchar(50)    NOT NULL,
    CILojinID     nvarchar(20)    NOT NULL,
    CIPassword    nvarchar(20)    NOT NULL,
    ClName        nvarchar(10)    NOT NULL,
    ClSex         char(2)         DEFAULT 'ÄÐ' NOT NULL
                  CONSTRAINT CK_ClSex CHECK (ClSex='ÄÐ' or ClSex='Å®'),
    ClIdentity    char(18)        NOT NULL
                  CONSTRAINT CK_ClIdentity CHECK (LEN(ClIdentity)=18),
    ClPhone       varchar(10)     NULL,
    ShID          nvarchar(50)    NOT NULL,
    CONSTRAINT PK2_3 PRIMARY KEY NONCLUSTERED (ClID)
)
go



IF OBJECT_ID('Clerk') IS NOT NULL
    PRINT '<<< CREATED TABLE Clerk >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Clerk >>>'
go

/* 
 * TABLE: Client 
 */

CREATE TABLE Client(
    CeID         nvarchar(50)    NOT NULL,
    CeName       nvarchar(10)    NOT NULL,
    CeAddress    text            NULL,
    CePhone      varchar(15)     NULL,
    CONSTRAINT PK1_2 PRIMARY KEY NONCLUSTERED (CeID)
)
go



IF OBJECT_ID('Client') IS NOT NULL
    PRINT '<<< CREATED TABLE Client >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Client >>>'
go

/* 
 * TABLE: Deliver 
 */

CREATE TABLE Deliver(
    DlID       nvarchar(50)    NOT NULL,
    DlCount    datetime        DEFAULT GETDATE() NOT NULL,
    SpID       nvarchar(50)    NOT NULL,
    GdID       nvarchar(50)    NOT NULL,
    CONSTRAINT PK2_2 PRIMARY KEY NONCLUSTERED (DlID)
)
go



IF OBJECT_ID('Deliver') IS NOT NULL
    PRINT '<<< CREATED TABLE Deliver >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Deliver >>>'
go

/* 
 * TABLE: Extract 
 */

CREATE TABLE Extract(
    EtID      nvarchar(50)    NOT NULL,
    EtDate    datetime        DEFAULT GETDATE() NOT NULL,
    WhID      nvarchar(50)    NOT NULL,
    CONSTRAINT PK6_1 PRIMARY KEY NONCLUSTERED (EtID)
)
go



IF OBJECT_ID('Extract') IS NOT NULL
    PRINT '<<< CREATED TABLE Extract >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Extract >>>'
go

/* 
 * TABLE: ExtractDetail 
 */

CREATE TABLE ExtractDetail(
    EDID       nvarchar(50)    NOT NULL,
    EDCount    int             NOT NULL,
    EtID       nvarchar(50)    NOT NULL,
    GdID       nvarchar(50)    NOT NULL,
    CONSTRAINT PK2_1 PRIMARY KEY NONCLUSTERED (EDID)
)
go



IF OBJECT_ID('ExtractDetail') IS NOT NULL
    PRINT '<<< CREATED TABLE ExtractDetail >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE ExtractDetail >>>'
go

/* 
 * TABLE: Goods 
 */

CREATE TABLE Goods(
    GdID               nvarchar(50)    NOT NULL,
    GdName             nvarchar(10)    NOT NULL,
    GdType             nvarchar(10)    NOT NULL,
    GdSpecification    nvarchar(10)    NOT NULL,
    GdUnit             nvarchar(5)     NOT NULL,
    CONSTRAINT PK3_1 PRIMARY KEY NONCLUSTERED (GdID)
)
go



IF OBJECT_ID('Goods') IS NOT NULL
    PRINT '<<< CREATED TABLE Goods >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Goods >>>'
go

/* 
 * TABLE: Purchase 
 */

CREATE TABLE Purchase(
    RID       nvarchar(50)    NOT NULL,
    PcDate    datetime        NOT NULL,
    WhID      nvarchar(50)    NOT NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (RID)
)
go



IF OBJECT_ID('Purchase') IS NOT NULL
    PRINT '<<< CREATED TABLE Purchase >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Purchase >>>'
go

/* 
 * TABLE: PurchaseDetail 
 */

CREATE TABLE PurchaseDetail(
    PDID       nvarchar(50)    NOT NULL,
    PDCount    int             NOT NULL,
    RID        nvarchar(50)    NOT NULL,
    GdID       nvarchar(50)    NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (PDID)
)
go



IF OBJECT_ID('PurchaseDetail') IS NOT NULL
    PRINT '<<< CREATED TABLE PurchaseDetail >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE PurchaseDetail >>>'
go

/* 
 * TABLE: Sales 
 */

CREATE TABLE Sales(
    SlID                nvarchar(50)    NOT NULL,
    SlRecordListDate    datetime        DEFAULT GETDATE() NOT NULL,
    ShID                nvarchar(50)    NOT NULL,
    CeID                nvarchar(50)    NOT NULL,
    CONSTRAINT PK4_2 PRIMARY KEY NONCLUSTERED (SlID)
)
go



IF OBJECT_ID('Sales') IS NOT NULL
    PRINT '<<< CREATED TABLE Sales >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Sales >>>'
go

/* 
 * TABLE: SalesDetail 
 */

CREATE TABLE SalesDetail(
    SDID       nvarchar(50)    NOT NULL,
    SDCount    int             NOT NULL,
    GdID       nvarchar(50)    NOT NULL,
    SlID       nvarchar(50)    NOT NULL,
    CONSTRAINT PK5_2 PRIMARY KEY NONCLUSTERED (SDID)
)
go



IF OBJECT_ID('SalesDetail') IS NOT NULL
    PRINT '<<< CREATED TABLE SalesDetail >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE SalesDetail >>>'
go

/* 
 * TABLE: Shop 
 */

CREATE TABLE Shop(
    ShID             nvarchar(50)    NOT NULL,
    ShName           nvarchar(10)    NOT NULL,
    ShAdress         text            NOT NULL,
    ShManagerName    nvarchar(10)    NOT NULL,
    ShPhone          varchar(15)     NULL,
    EtID             nvarchar(50)    NOT NULL,
    CONSTRAINT PK3_2 PRIMARY KEY NONCLUSTERED (ShID)
)
go



IF OBJECT_ID('Shop') IS NOT NULL
    PRINT '<<< CREATED TABLE Shop >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Shop >>>'
go

/* 
 * TABLE: Supplier 
 */

CREATE TABLE Supplier(
    SpID          nvarchar(50)    NOT NULL,
    SpLoginID     nvarchar(50)    NOT NULL,
    SpPassword    nvarchar(20)    NOT NULL,
    SpName        nvarchar(10)    NOT NULL,
    SpContact     nvarchar(10)    NOT NULL,
    SpPhone       varchar(15)     NULL,
    CONSTRAINT PK1_1 PRIMARY KEY NONCLUSTERED (SpID)
)
go



IF OBJECT_ID('Supplier') IS NOT NULL
    PRINT '<<< CREATED TABLE Supplier >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Supplier >>>'
go

/* 
 * TABLE: Warehouse 
 */

CREATE TABLE Warehouse(
    WhID         nvarchar(50)    NOT NULL,
    WhName       nvarchar(10)    NOT NULL,
    WhAdress     text            NOT NULL,
    WhExplain    text            NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (WhID)
)
go



IF OBJECT_ID('Warehouse') IS NOT NULL
    PRINT '<<< CREATED TABLE Warehouse >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Warehouse >>>'
go

/* 
 * TABLE: WarehouseAdmin 
 */

CREATE TABLE WarehouseAdmin(
    WAID          nvarchar(50)    NOT NULL,
    WALojinID     nvarchar(20)    NOT NULL,
    WAPassword    nvarchar(20)    NOT NULL,
    WAName        nvarchar(10)    NOT NULL,
    WASex         char(2)         DEFAULT 'ÄÐ' NOT NULL
                  CONSTRAINT CK_WASex CHECK (WASex='ÄÐ' or WASex='Å®'),
    WACardID      char(18)        NOT NULL
                  CONSTRAINT CK_WACardID CHECK (len(WACardID)=18),
    WAphone       varchar(15)     NULL,
    WhID          nvarchar(50)    NOT NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (WAID)
)
go



IF OBJECT_ID('WarehouseAdmin') IS NOT NULL
    PRINT '<<< CREATED TABLE WarehouseAdmin >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE WarehouseAdmin >>>'
go

/* 
 * TABLE: Clerk 
 */

ALTER TABLE Clerk ADD CONSTRAINT RefShop13 
    FOREIGN KEY (ShID)
    REFERENCES Shop(ShID)
go


/* 
 * TABLE: Deliver 
 */

ALTER TABLE Deliver ADD CONSTRAINT RefSupplier10 
    FOREIGN KEY (SpID)
    REFERENCES Supplier(SpID)
go

ALTER TABLE Deliver ADD CONSTRAINT RefGoods61 
    FOREIGN KEY (GdID)
    REFERENCES Goods(GdID)
go


/* 
 * TABLE: Extract 
 */

ALTER TABLE Extract ADD CONSTRAINT RefWarehouse34 
    FOREIGN KEY (WhID)
    REFERENCES Warehouse(WhID)
go


/* 
 * TABLE: ExtractDetail 
 */

ALTER TABLE ExtractDetail ADD CONSTRAINT RefExtract53 
    FOREIGN KEY (EtID)
    REFERENCES Extract(EtID)
go

ALTER TABLE ExtractDetail ADD CONSTRAINT RefGoods55 
    FOREIGN KEY (GdID)
    REFERENCES Goods(GdID)
go


/* 
 * TABLE: Purchase 
 */

ALTER TABLE Purchase ADD CONSTRAINT RefWarehouse2 
    FOREIGN KEY (WhID)
    REFERENCES Warehouse(WhID)
go


/* 
 * TABLE: PurchaseDetail 
 */

ALTER TABLE PurchaseDetail ADD CONSTRAINT RefPurchase49 
    FOREIGN KEY (RID)
    REFERENCES Purchase(RID)
go

ALTER TABLE PurchaseDetail ADD CONSTRAINT RefGoods50 
    FOREIGN KEY (GdID)
    REFERENCES Goods(GdID)
go


/* 
 * TABLE: Sales 
 */

ALTER TABLE Sales ADD CONSTRAINT RefClient58 
    FOREIGN KEY (CeID)
    REFERENCES Client(CeID)
go

ALTER TABLE Sales ADD CONSTRAINT RefShop12 
    FOREIGN KEY (ShID)
    REFERENCES Shop(ShID)
go


/* 
 * TABLE: SalesDetail 
 */

ALTER TABLE SalesDetail ADD CONSTRAINT RefGoods56 
    FOREIGN KEY (GdID)
    REFERENCES Goods(GdID)
go

ALTER TABLE SalesDetail ADD CONSTRAINT RefSales57 
    FOREIGN KEY (SlID)
    REFERENCES Sales(SlID)
go


/* 
 * TABLE: Shop 
 */

ALTER TABLE Shop ADD CONSTRAINT RefExtract33 
    FOREIGN KEY (EtID)
    REFERENCES Extract(EtID)
go


/* 
 * TABLE: WarehouseAdmin 
 */

ALTER TABLE WarehouseAdmin ADD CONSTRAINT RefWarehouse1 
    FOREIGN KEY (WhID)
    REFERENCES Warehouse(WhID)
go
