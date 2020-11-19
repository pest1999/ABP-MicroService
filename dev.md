# 路线图

## 目的：验证微服务权限验证，微服务内获取身份信息，服务间调用等，从而确认微服务的基础知识。

以 ABP-MicroService 为基础，在 Dev 分支中分步实施，验证成功后勾选，并标记注意事项。[^1]

- [x] 分别添加订单和产品服务。[^2]
- [x] 分别实现 Domain 层
- [x] 分别更新数据库
- [x] 服务内添加权限[^3]
- [x] BaseServices 添加权限[^4]
- [ ] 前端 Vue 添加页面，并完成基础功能（curd）。
- [ ] 微服务内获取用户身份信息，并进一步改造 BaseServices 向 Claim 添加自定义身份信息
- [ ] 微服务间相互调用
- [ ] 微服务间通过 EventBus 发布、订阅。实现应用的提交、实现分离，提升复杂应用的处理效率。
- [ ] 进一步了解 Vue 前端基础知识，弄清 Vue 与 Vnext 配套的身份验证部分。
- [ ] 深入了解 Vue 框架知识，重点是 Route、模块通信
- [ ] Vue 进阶，尝试通过后台 swagger 的 json 生成 ts 模型

---
## 实施纪要

 [^1]: 启动实施。2020/11/18 11：30
 [^2]: 创建微服务OrderAp和ProductAp 2020/11/18
 [^3]: 添加OrderApPermissions，不要实现PermissionDefinitionProvider，留在BaseServices中实现。注意需添加ConfigureConventionalControllers，否则appservices中的服务不会自动转换成api 2020/11/18
 [^4]: BaseService.Application.Contracts项目通过私有nuget添加Pest.OrderAp.Application.Contracts（权限修改是需要更新，否则不用）。BaseServicePermissionDefinitionProvider 中添加微服务的权限，启动后会通过seed植入。 2020/11/18