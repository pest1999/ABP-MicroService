# 路线图
---
***文档：***  document下doc.md
***系统架构：*** abp vnext 4.0
***DotNet版本：*** 5.0
***运行平台：*** Centos7
***数据库等：*** docker发布

---
## 目标：验证微服务功能，及快速开发方式。
以[ABP-MicroService](https://github.com/WilliamXu96/ABP-MicroService) 为基础，结合abp-samples 中 [MicroserviceDemo](https://github.com/abpframework/abp-samples/tree/master/MicroserviceDemo) ，以 Dev02 分支 验证服务间调用。以 Dev04 分支验证开发实施，验证成功后勾选，并标记注意事项。


- [ ] 验证升级vnext 4.0 后各项功能。
- [ ] 验证apb cli 创建module后植入微服务。
- [ ] 验证apb helper 代码生成功能。
- [ ] 验证业务服务间，通过内部的权限管理
- [ ] 了解远端服务与网关间配合方式
- [ ] 测试Jenkins自动发布 
- [ ] 测试docker管理工具
- [ ] 了解日志分析
- [ ] 业务服务内部调用，与单体服务间的差异
- [ ] 改造 BaseServices 向 Claim 添加自定义身份信息
- [ ] 分布式事务。业务服务间通过 CAP（或vnext原生的EventBus） 发布、订阅。实现应用的提交、实现分离，提升复杂应用的处理效率。
- [ ] 网关业务聚合。
- [ ] 服务发现与治理
- [ ] 进一步了解Vue基础支持，弄清 Vue 与 Vnext 配套的身份验证部分
- [ ] 深入了解 Vue 框架知识，重点是 Route、模块通信 
- [ ] Vue 进阶，尝试通过后台 swagger 的 json 生成 ts 模型。

---
## 实施纪要

