# DependencyInjectionSample
- DI: Dependency Injection (依賴注入)：
把要依賴的部分通通在 IoC 容器裡面都配置好，日後當類別要依賴B物件時，容器就會主動提供配置好的物件給它做使用。
- IoC: Inversion of Controll (控制反轉)：
讓依賴B的部分轉為依賴 IoC 容器，再由 IoC 容器提供B物件來做使用

### 文章說明：可參考前同事 Max 的 Medium 文章
https://max-lin.medium.com/%E7%9B%B8%E4%BE%9D%E6%80%A7%E6%B3%A8%E5%85%A5-di-ioc-9a80aa48f68c


## 此為練習用Project
- 使用 .NetFramework 4.7.2
- 使用 ConsoleApplication 專案
- 使用 Unity IOC套件

### 練習步驟
1. Clone Remote Project to Local
2. 切換不同Commit觀察逐漸加入 IOC 的演變

