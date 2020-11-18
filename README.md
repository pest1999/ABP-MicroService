**账号密码：** `admin/1q2w3E*`
#### 一. 项目结构
- 认证 AuthServer
- 授权及基础服务 BaseService
- 微服务  MicroServices文件夹下
- 网关  Gateways文件夹下

>**网关介绍** 
- web网关  WebAppGateway。
用于对接前端Vue
- 内部网关 项目下InternalGateway未启用，内部网关服务合并至BaseService


>**微服务介绍**
- 文件存储 FileStorage
用于文件上传下载。编辑FileStorage.Host项目UploadController的Upload方法， 控制文件大小、支持的类别。
填加了权限控制（未验证）
- 微服务范本 Business
系统工具部分功能（表单管理），添加了权限（已验证）

>**基础服务**
即BaseService
- 组织架构、岗位管理、数据字典等
- 系统工具（代码生成）
- 全局权限管理（个人理解）

#### 二. 新建微服务业务过程
1. MicroServices文件夹下创建新项目。
> 参照Business、AMS添加
> **注意：** 参照下图，添加PermissionDefinitionProvider的实现
>> <img src=".\imgs\permission.png">
2. 新项目打包发布至私有nuget。
- 项目打包
按照下图，勾选“在构建时生成Nuget包。
注意需要把用到的项目（Application、Application.Contracts）分别打包
<img src=".\imgs\package.png">
- 上传nuget
> 这里我们使用nexus建设私有nuget（含maven），地址192.168.168.177:8081，在upload菜单上传打包后的文件（如：Pest.Business.HttpApi.1.0.1.nupkg）
> <img src=".\imgs\upload.jpg">

3. 基础服务（即BaseService）引用新的nuget文件
> 添加nuget源
>> <img src=".\imgs\mynuget.png">
> 添加依赖
>> <img src=".\imgs\using.png">
> 注入host项目
>> <img src=".\imgs\using2.png">

4. 重新初始化基础服务（即BaseService）
运行后，会更新数据库的permission部分。
**注意：**业务和微服务不要重复做permission设置，否则会冲突
