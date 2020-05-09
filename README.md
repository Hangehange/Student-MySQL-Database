# Student-MySQL-Database
MySQL+C#的三级架构学生成绩信息管理系统。云服务器部署MySQL server，本地基于C#+.NET开发带界面

· 三级架构：由和数据直接打交道，到直接和用户打交道的界面
    1.数据访问层:Data Access Layer       利用一个通用的MySQL语句模式直接访问数据库
    2.业务逻辑层:Bussiness Logic Layer   使用MySQL语句对数据库实现增删改查
    3.用户接口层:User Interface Layer    结合用户界面，将查询表和用户关键字交互起来
    此外，一个Tool类，封装了大量MySQL实用方法，可供DAL和BLL调用

· 关于云数据库
    私有云：hangecloud.club:8080，需要使用的可以联系QQ：257993379


