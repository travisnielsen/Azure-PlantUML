# Azure Symbols

The following table lists all Azure symbols which are part of Azure-PlantUML.
They are categorized using their primary category.

If you want to be independent of any internet connectifity, you can also download the whole [Azure-PlantUML dist](dist/) and reference it locally with

```c#
!define AzurePuml path/to
!include AzurePuml/AzureCommon.puml
!include AzurePuml/Databases/AzureCosmosDb.puml
!include AzurePuml/Compute/AzureFunction.puml
```

If you want to use the always up-to-date version in this repo, use the following:

```c#
!define AzurePuml https://raw.githubusercontent.com/RicardoNiepel/Azure-PlantUML/master/dist
!includeurl AzurePuml/AzureCommon.puml
!includeurl AzurePuml/Databases/AzureCosmosDb.puml
!includeurl AzurePuml/Compute/AzureFunction.puml
```

## SVG and PNG images, PPTX file

You can also use the colored and monochrom SVG and PNG images outside of PlantUML, e.g. for documents or presentations.

There is also a PowerPoint file (PPTX) which includes alls Azure symbols as SVGs: [Azure_Symbols.pptx](dist/Azure_Symbols.pptx?raw=true).

> If the size of the generated PNG images is not enough for you, take a look at [how you can build Azure-PlantUML on your own](scripts/README.md).

## All generated Azure symbols (SVG and PNG) and PlantUML sprites

Category | Macro (Name) | <pre>Color</pre> | <pre>Mono </pre> | Url
  ---    |  ---  | :---:  | :---: | ---
**AIMachineLearning** | | | | **AIMachineLearning/all.puml**
AIMachineLearning | BotServices </br> (Bot Services) | ![BotServices](dist/AIMachineLearning/BotServices.png?raw=true) | ![BotServices](dist/AIMachineLearning/BotServices(m).png?raw=true) | AIMachineLearning/BotServices.puml
AIMachineLearning | CognitiveServices </br> (Cognitive Services) | ![CognitiveServices](dist/AIMachineLearning/CognitiveServices.png?raw=true) | ![CognitiveServices](dist/AIMachineLearning/CognitiveServices(m).png?raw=true) | AIMachineLearning/CognitiveServices.puml
AIMachineLearning | MachineLearningService </br> (Machine Learning Service) | ![MachineLearningService](dist/AIMachineLearning/MachineLearningService.png?raw=true) | ![MachineLearningService](dist/AIMachineLearning/MachineLearningService(m).png?raw=true) | AIMachineLearning/MachineLearningService.puml
AIMachineLearning | MicrosoftGenomics </br> (Microsoft Genomics) | ![MicrosoftGenomics](dist/AIMachineLearning/MicrosoftGenomics.png?raw=true) | ![MicrosoftGenomics](dist/AIMachineLearning/MicrosoftGenomics(m).png?raw=true) | AIMachineLearning/MicrosoftGenomics.puml
**Analytics** | | | | **Analytics/all.puml**
Analytics | AnalysisServices </br> (Analysis Services) | ![AnalysisServices](dist/Analytics/AnalysisServices.png?raw=true) | ![AnalysisServices](dist/Analytics/AnalysisServices(m).png?raw=true) | Analytics/AnalysisServices.puml
Analytics | AzureDatabricks </br> (Azure Databricks) | ![AzureDatabricks](dist/Analytics/AzureDatabricks.png?raw=true) | ![AzureDatabricks](dist/Analytics/AzureDatabricks(m).png?raw=true) | Analytics/AzureDatabricks.puml
Analytics | AzureDataExplorerClusters </br> (Azure Data Explorer Clusters) | ![AzureDataExplorerClusters](dist/Analytics/AzureDataExplorerClusters.png?raw=true) | ![AzureDataExplorerClusters](dist/Analytics/AzureDataExplorerClusters(m).png?raw=true) | Analytics/AzureDataExplorerClusters.puml
Analytics | AzureSynapseAnalytics </br> (Azure Synapse Analytics) | ![AzureSynapseAnalytics](dist/Analytics/AzureSynapseAnalytics.png?raw=true) | ![AzureSynapseAnalytics](dist/Analytics/AzureSynapseAnalytics(m).png?raw=true) | Analytics/AzureSynapseAnalytics.puml
Analytics | DataFactory </br> (Data Factory) | ![DataFactory](dist/Analytics/DataFactory.png?raw=true) | ![DataFactory](dist/Analytics/DataFactory(m).png?raw=true) | Analytics/DataFactory.puml
Analytics | DataLakeStoreGen1 </br> (Data Lake Store Gen1) | ![DataLakeStoreGen1](dist/Analytics/DataLakeStoreGen1.png?raw=true) | ![DataLakeStoreGen1](dist/Analytics/DataLakeStoreGen1(m).png?raw=true) | Analytics/DataLakeStoreGen1.puml
Analytics | HDInsightClusters </br> (HD Insight Clusters) | ![HDInsightClusters](dist/Analytics/HDInsightClusters.png?raw=true) | ![HDInsightClusters](dist/Analytics/HDInsightClusters(m).png?raw=true) | Analytics/HDInsightClusters.puml
Analytics | LogAnalyticsWorkspaces </br> (Log Analytics Workspaces) | ![LogAnalyticsWorkspaces](dist/Analytics/LogAnalyticsWorkspaces.png?raw=true) | ![LogAnalyticsWorkspaces](dist/Analytics/LogAnalyticsWorkspaces(m).png?raw=true) | Analytics/LogAnalyticsWorkspaces.puml
Analytics | StreamAnalyticsJobs </br> (Stream Analytics Jobs) | ![StreamAnalyticsJobs](dist/Analytics/StreamAnalyticsJobs.png?raw=true) | ![StreamAnalyticsJobs](dist/Analytics/StreamAnalyticsJobs(m).png?raw=true) | Analytics/StreamAnalyticsJobs.puml
Analytics | TimeSeriesInsights </br> (Time Series Insights) | ![TimeSeriesInsights](dist/Analytics/TimeSeriesInsights.png?raw=true) | ![TimeSeriesInsights](dist/Analytics/TimeSeriesInsights(m).png?raw=true) | Analytics/TimeSeriesInsights.puml
**AzureStack** | | | | **AzureStack/all.puml**
AzureStack | MultiTenancy </br> (Multi Tenancy) | ![MultiTenancy](dist/AzureStack/MultiTenancy.png?raw=true) | ![MultiTenancy](dist/AzureStack/MultiTenancy(m).png?raw=true) | AzureStack/MultiTenancy.puml
**AzureVMwareSolution** | | | | **AzureVMwareSolution/all.puml**
AzureVMwareSolution | AVS </br> (AVS) | ![AVS](dist/AzureVMwareSolution/AVS.png?raw=true) | ![AVS](dist/AzureVMwareSolution/AVS(m).png?raw=true) | AzureVMwareSolution/AVS.puml
**Blockchain** | | | | **Blockchain/all.puml**
Blockchain | AzureBlockchainService </br> (Azure Blockchain Service) | ![AzureBlockchainService](dist/Blockchain/AzureBlockchainService.png?raw=true) | ![AzureBlockchainService](dist/Blockchain/AzureBlockchainService(m).png?raw=true) | Blockchain/AzureBlockchainService.puml
**Compute** | | | | **Compute/all.puml**
Compute | APIManagementServices </br> (A PIManagement Services) | ![APIManagementServices](dist/Compute/APIManagementServices.png?raw=true) | ![APIManagementServices](dist/Compute/APIManagementServices(m).png?raw=true) | Compute/APIManagementServices.puml
Compute | AppServiceCertificates </br> (App Service Certificates) | ![AppServiceCertificates](dist/Compute/AppServiceCertificates.png?raw=true) | ![AppServiceCertificates](dist/Compute/AppServiceCertificates(m).png?raw=true) | Compute/AppServiceCertificates.puml
Compute | AppServiceDomains </br> (App Service Domains) | ![AppServiceDomains](dist/Compute/AppServiceDomains.png?raw=true) | ![AppServiceDomains](dist/Compute/AppServiceDomains(m).png?raw=true) | Compute/AppServiceDomains.puml
Compute | AppServiceEnvironments </br> (App Service Environments) | ![AppServiceEnvironments](dist/Compute/AppServiceEnvironments.png?raw=true) | ![AppServiceEnvironments](dist/Compute/AppServiceEnvironments(m).png?raw=true) | Compute/AppServiceEnvironments.puml
Compute | AppServicePlans </br> (App Service Plans) | ![AppServicePlans](dist/Compute/AppServicePlans.png?raw=true) | ![AppServicePlans](dist/Compute/AppServicePlans(m).png?raw=true) | Compute/AppServicePlans.puml
Compute | AppServices </br> (App Services) | ![AppServices](dist/Compute/AppServices.png?raw=true) | ![AppServices](dist/Compute/AppServices(m).png?raw=true) | Compute/AppServices.puml
Compute | AvailabilitySets </br> (Availability Sets) | ![AvailabilitySets](dist/Compute/AvailabilitySets.png?raw=true) | ![AvailabilitySets](dist/Compute/AvailabilitySets(m).png?raw=true) | Compute/AvailabilitySets.puml
Compute | BatchAccounts </br> (Batch Accounts) | ![BatchAccounts](dist/Compute/BatchAccounts.png?raw=true) | ![BatchAccounts](dist/Compute/BatchAccounts(m).png?raw=true) | Compute/BatchAccounts.puml
Compute | CloudServices(Classic) </br> (Cloud Services( Classic)) | ![CloudServices(Classic)](dist/Compute/CloudServices(Classic).png?raw=true) | ![CloudServices(Classic)](dist/Compute/CloudServices(Classic)(m).png?raw=true) | Compute/CloudServices(Classic).puml
Compute | Disks </br> (Disks) | ![Disks](dist/Compute/Disks.png?raw=true) | ![Disks](dist/Compute/Disks(m).png?raw=true) | Compute/Disks.puml
Compute | DisksSnapshots </br> (Disks Snapshots) | ![DisksSnapshots](dist/Compute/DisksSnapshots.png?raw=true) | ![DisksSnapshots](dist/Compute/DisksSnapshots(m).png?raw=true) | Compute/DisksSnapshots.puml
Compute | FunctionApps </br> (Function Apps) | ![FunctionApps](dist/Compute/FunctionApps.png?raw=true) | ![FunctionApps](dist/Compute/FunctionApps(m).png?raw=true) | Compute/FunctionApps.puml
Compute | ImageDefinitions </br> (Image Definitions) | ![ImageDefinitions](dist/Compute/ImageDefinitions.png?raw=true) | ![ImageDefinitions](dist/Compute/ImageDefinitions(m).png?raw=true) | Compute/ImageDefinitions.puml
Compute | Images </br> (Images) | ![Images](dist/Compute/Images.png?raw=true) | ![Images](dist/Compute/Images(m).png?raw=true) | Compute/Images.puml
Compute | ImageVersions </br> (Image Versions) | ![ImageVersions](dist/Compute/ImageVersions.png?raw=true) | ![ImageVersions](dist/Compute/ImageVersions(m).png?raw=true) | Compute/ImageVersions.puml
Compute | KubernetesServices </br> (Kubernetes Services) | ![KubernetesServices](dist/Compute/KubernetesServices.png?raw=true) | ![KubernetesServices](dist/Compute/KubernetesServices(m).png?raw=true) | Compute/KubernetesServices.puml
Compute | MeshApplications </br> (Mesh Applications) | ![MeshApplications](dist/Compute/MeshApplications.png?raw=true) | ![MeshApplications](dist/Compute/MeshApplications(m).png?raw=true) | Compute/MeshApplications.puml
Compute | NotificationHubs </br> (Notification Hubs) | ![NotificationHubs](dist/Compute/NotificationHubs.png?raw=true) | ![NotificationHubs](dist/Compute/NotificationHubs(m).png?raw=true) | Compute/NotificationHubs.puml
Compute | OSImages(Classic) </br> (OS Images( Classic)) | ![OSImages(Classic)](dist/Compute/OSImages(Classic).png?raw=true) | ![OSImages(Classic)](dist/Compute/OSImages(Classic)(m).png?raw=true) | Compute/OSImages(Classic).puml
Compute | ServiceFabricClusters </br> (Service Fabric Clusters) | ![ServiceFabricClusters](dist/Compute/ServiceFabricClusters.png?raw=true) | ![ServiceFabricClusters](dist/Compute/ServiceFabricClusters(m).png?raw=true) | Compute/ServiceFabricClusters.puml
Compute | SharedImageGalleries </br> (Shared Image Galleries) | ![SharedImageGalleries](dist/Compute/SharedImageGalleries.png?raw=true) | ![SharedImageGalleries](dist/Compute/SharedImageGalleries(m).png?raw=true) | Compute/SharedImageGalleries.puml
Compute | VirtualMachine </br> (Virtual Machine) | ![VirtualMachine](dist/Compute/VirtualMachine.png?raw=true) | ![VirtualMachine](dist/Compute/VirtualMachine(m).png?raw=true) | Compute/VirtualMachine.puml
Compute | VMImages(Classic) </br> (VM Images( Classic)) | ![VMImages(Classic)](dist/Compute/VMImages(Classic).png?raw=true) | ![VMImages(Classic)](dist/Compute/VMImages(Classic)(m).png?raw=true) | Compute/VMImages(Classic).puml
Compute | VMScaleSets </br> (VM Scale Sets) | ![VMScaleSets](dist/Compute/VMScaleSets.png?raw=true) | ![VMScaleSets](dist/Compute/VMScaleSets(m).png?raw=true) | Compute/VMScaleSets.puml
Compute | WebSlots </br> (Web Slots) | ![WebSlots](dist/Compute/WebSlots.png?raw=true) | ![WebSlots](dist/Compute/WebSlots(m).png?raw=true) | Compute/WebSlots.puml
Compute | Workspaces </br> (Workspaces) | ![Workspaces](dist/Compute/Workspaces.png?raw=true) | ![Workspaces](dist/Compute/Workspaces(m).png?raw=true) | Compute/Workspaces.puml
**Containers** | | | | **Containers/all.puml**
Containers | BatchAccounts </br> (Batch Accounts) | ![BatchAccounts](dist/Containers/BatchAccounts.png?raw=true) | ![BatchAccounts](dist/Containers/BatchAccounts(m).png?raw=true) | Containers/BatchAccounts.puml
Containers | ContainerRegistries </br> (Container Registries) | ![ContainerRegistries](dist/Containers/ContainerRegistries.png?raw=true) | ![ContainerRegistries](dist/Containers/ContainerRegistries(m).png?raw=true) | Containers/ContainerRegistries.puml
Containers | KubernetesServices </br> (Kubernetes Services) | ![KubernetesServices](dist/Containers/KubernetesServices.png?raw=true) | ![KubernetesServices](dist/Containers/KubernetesServices(m).png?raw=true) | Containers/KubernetesServices.puml
Containers | ServiceFabricClusters </br> (Service Fabric Clusters) | ![ServiceFabricClusters](dist/Containers/ServiceFabricClusters.png?raw=true) | ![ServiceFabricClusters](dist/Containers/ServiceFabricClusters(m).png?raw=true) | Containers/ServiceFabricClusters.puml
**Databases** | | | | **Databases/all.puml**
Databases | AzureCosmosDB </br> (Azure CosmosDB) | ![AzureCosmosDB](dist/Databases/AzureCosmosDB.png?raw=true) | ![AzureCosmosDB](dist/Databases/AzureCosmosDB(m).png?raw=true) | Databases/AzureCosmosDB.puml
Databases | AzureDatabaseMariaDBServer </br> (Azure Database Maria DBServer) | ![AzureDatabaseMariaDBServer](dist/Databases/AzureDatabaseMariaDBServer.png?raw=true) | ![AzureDatabaseMariaDBServer](dist/Databases/AzureDatabaseMariaDBServer(m).png?raw=true) | Databases/AzureDatabaseMariaDBServer.puml
Databases | AzureDatabaseMySQLServer </br> (Azure Database My SQL Server) | ![AzureDatabaseMySQLServer](dist/Databases/AzureDatabaseMySQLServer.png?raw=true) | ![AzureDatabaseMySQLServer](dist/Databases/AzureDatabaseMySQLServer(m).png?raw=true) | Databases/AzureDatabaseMySQLServer.puml
Databases | AzureDatabasePostgreSQLServer </br> (Azure Database Postgre SQL Server) | ![AzureDatabasePostgreSQLServer](dist/Databases/AzureDatabasePostgreSQLServer.png?raw=true) | ![AzureDatabasePostgreSQLServer](dist/Databases/AzureDatabasePostgreSQLServer(m).png?raw=true) | Databases/AzureDatabasePostgreSQLServer.puml
Databases | AzureDataExplorerClusters </br> (Azure Data Explorer Clusters) | ![AzureDataExplorerClusters](dist/Databases/AzureDataExplorerClusters.png?raw=true) | ![AzureDataExplorerClusters](dist/Databases/AzureDataExplorerClusters(m).png?raw=true) | Databases/AzureDataExplorerClusters.puml
Databases | AzureSQLServerStretchDatabases </br> (Azure SQL Server Stretch Databases) | ![AzureSQLServerStretchDatabases](dist/Databases/AzureSQLServerStretchDatabases.png?raw=true) | ![AzureSQLServerStretchDatabases](dist/Databases/AzureSQLServerStretchDatabases(m).png?raw=true) | Databases/AzureSQLServerStretchDatabases.puml
Databases | AzureSQLVM </br> (Azure SQLVM) | ![AzureSQLVM](dist/Databases/AzureSQLVM.png?raw=true) | ![AzureSQLVM](dist/Databases/AzureSQLVM(m).png?raw=true) | Databases/AzureSQLVM.puml
Databases | AzureSynapseAnalytics </br> (Azure Synapse Analytics) | ![AzureSynapseAnalytics](dist/Databases/AzureSynapseAnalytics.png?raw=true) | ![AzureSynapseAnalytics](dist/Databases/AzureSynapseAnalytics(m).png?raw=true) | Databases/AzureSynapseAnalytics.puml
Databases | CacheRedis </br> (Cache Redis) | ![CacheRedis](dist/Databases/CacheRedis.png?raw=true) | ![CacheRedis](dist/Databases/CacheRedis(m).png?raw=true) | Databases/CacheRedis.puml
Databases | DataFactory </br> (Data Factory) | ![DataFactory](dist/Databases/DataFactory.png?raw=true) | ![DataFactory](dist/Databases/DataFactory(m).png?raw=true) | Databases/DataFactory.puml
Databases | ElasticJobAgents </br> (Elastic Job Agents) | ![ElasticJobAgents](dist/Databases/ElasticJobAgents.png?raw=true) | ![ElasticJobAgents](dist/Databases/ElasticJobAgents(m).png?raw=true) | Databases/ElasticJobAgents.puml
Databases | InstancePools </br> (Instance Pools) | ![InstancePools](dist/Databases/InstancePools.png?raw=true) | ![InstancePools](dist/Databases/InstancePools(m).png?raw=true) | Databases/InstancePools.puml
Databases | ManagedDatabase </br> (Managed Database) | ![ManagedDatabase](dist/Databases/ManagedDatabase.png?raw=true) | ![ManagedDatabase](dist/Databases/ManagedDatabase(m).png?raw=true) | Databases/ManagedDatabase.puml
Databases | SQLDatabase </br> (S QLDatabase) | ![SQLDatabase](dist/Databases/SQLDatabase.png?raw=true) | ![SQLDatabase](dist/Databases/SQLDatabase(m).png?raw=true) | Databases/SQLDatabase.puml
Databases | SQLDataWarehouses </br> (S QLData Warehouses) | ![SQLDataWarehouses](dist/Databases/SQLDataWarehouses.png?raw=true) | ![SQLDataWarehouses](dist/Databases/SQLDataWarehouses(m).png?raw=true) | Databases/SQLDataWarehouses.puml
Databases | SQLElasticPools </br> (S QLElastic Pools) | ![SQLElasticPools](dist/Databases/SQLElasticPools.png?raw=true) | ![SQLElasticPools](dist/Databases/SQLElasticPools(m).png?raw=true) | Databases/SQLElasticPools.puml
Databases | SQLManagedInstance </br> (S QLManaged Instance) | ![SQLManagedInstance](dist/Databases/SQLManagedInstance.png?raw=true) | ![SQLManagedInstance](dist/Databases/SQLManagedInstance(m).png?raw=true) | Databases/SQLManagedInstance.puml
Databases | SQLServer </br> (S QLServer) | ![SQLServer](dist/Databases/SQLServer.png?raw=true) | ![SQLServer](dist/Databases/SQLServer(m).png?raw=true) | Databases/SQLServer.puml
Databases | VirtualClusters </br> (Virtual Clusters) | ![VirtualClusters](dist/Databases/VirtualClusters.png?raw=true) | ![VirtualClusters](dist/Databases/VirtualClusters(m).png?raw=true) | Databases/VirtualClusters.puml
**DevOps** | | | | **DevOps/all.puml**
DevOps | ApplicationInsights </br> (Application Insights) | ![ApplicationInsights](dist/DevOps/ApplicationInsights.png?raw=true) | ![ApplicationInsights](dist/DevOps/ApplicationInsights(m).png?raw=true) | DevOps/ApplicationInsights.puml
DevOps | Artifacts </br> (Artifacts) | ![Artifacts](dist/DevOps/Artifacts.png?raw=true) | ![Artifacts](dist/DevOps/Artifacts(m).png?raw=true) | DevOps/Artifacts.puml
DevOps | AzureDevOps </br> (Azure Dev Ops) | ![AzureDevOps](dist/DevOps/AzureDevOps.png?raw=true) | ![AzureDevOps](dist/DevOps/AzureDevOps(m).png?raw=true) | DevOps/AzureDevOps.puml
DevOps | Boards </br> (Boards) | ![Boards](dist/DevOps/Boards.png?raw=true) | ![Boards](dist/DevOps/Boards(m).png?raw=true) | DevOps/Boards.puml
DevOps | Branch </br> (Branch) | ![Branch](dist/DevOps/Branch.png?raw=true) | ![Branch](dist/DevOps/Branch(m).png?raw=true) | DevOps/Branch.puml
DevOps | Browser </br> (Browser) | ![Browser](dist/DevOps/Browser.png?raw=true) | ![Browser](dist/DevOps/Browser(m).png?raw=true) | DevOps/Browser.puml
DevOps | Bug </br> (Bug) | ![Bug](dist/DevOps/Bug.png?raw=true) | ![Bug](dist/DevOps/Bug(m).png?raw=true) | DevOps/Bug.puml
DevOps | Builds </br> (Builds) | ![Builds](dist/DevOps/Builds.png?raw=true) | ![Builds](dist/DevOps/Builds(m).png?raw=true) | DevOps/Builds.puml
DevOps | Cache </br> (Cache) | ![Cache](dist/DevOps/Cache.png?raw=true) | ![Cache](dist/DevOps/Cache(m).png?raw=true) | DevOps/Cache.puml
DevOps | Code </br> (Code) | ![Code](dist/DevOps/Code.png?raw=true) | ![Code](dist/DevOps/Code(m).png?raw=true) | DevOps/Code.puml
DevOps | Commit </br> (Commit) | ![Commit](dist/DevOps/Commit.png?raw=true) | ![Commit](dist/DevOps/Commit(m).png?raw=true) | DevOps/Commit.puml
DevOps | Controls </br> (Controls) | ![Controls](dist/DevOps/Controls.png?raw=true) | ![Controls](dist/DevOps/Controls(m).png?raw=true) | DevOps/Controls.puml
DevOps | ControlsHorizontal </br> (Controls Horizontal) | ![ControlsHorizontal](dist/DevOps/ControlsHorizontal.png?raw=true) | ![ControlsHorizontal](dist/DevOps/ControlsHorizontal(m).png?raw=true) | DevOps/ControlsHorizontal.puml
DevOps | DevTestLabs </br> (Dev Test Labs) | ![DevTestLabs](dist/DevOps/DevTestLabs.png?raw=true) | ![DevTestLabs](dist/DevOps/DevTestLabs(m).png?raw=true) | DevOps/DevTestLabs.puml
DevOps | LabServices </br> (Lab Services) | ![LabServices](dist/DevOps/LabServices.png?raw=true) | ![LabServices](dist/DevOps/LabServices(m).png?raw=true) | DevOps/LabServices.puml
DevOps | LoadTest </br> (Load Test) | ![LoadTest](dist/DevOps/LoadTest.png?raw=true) | ![LoadTest](dist/DevOps/LoadTest(m).png?raw=true) | DevOps/LoadTest.puml
DevOps | Pipelines </br> (Pipelines) | ![Pipelines](dist/DevOps/Pipelines.png?raw=true) | ![Pipelines](dist/DevOps/Pipelines(m).png?raw=true) | DevOps/Pipelines.puml
DevOps | Repos </br> (Repos) | ![Repos](dist/DevOps/Repos.png?raw=true) | ![Repos](dist/DevOps/Repos(m).png?raw=true) | DevOps/Repos.puml
DevOps | TestPlans </br> (Test Plans) | ![TestPlans](dist/DevOps/TestPlans.png?raw=true) | ![TestPlans](dist/DevOps/TestPlans(m).png?raw=true) | DevOps/TestPlans.puml
DevOps | Versions </br> (Versions) | ![Versions](dist/DevOps/Versions.png?raw=true) | ![Versions](dist/DevOps/Versions(m).png?raw=true) | DevOps/Versions.puml
DevOps | WebsitePower </br> (Website Power) | ![WebsitePower](dist/DevOps/WebsitePower.png?raw=true) | ![WebsitePower](dist/DevOps/WebsitePower(m).png?raw=true) | DevOps/WebsitePower.puml
DevOps | WebsiteStaging </br> (Website Staging) | ![WebsiteStaging](dist/DevOps/WebsiteStaging.png?raw=true) | ![WebsiteStaging](dist/DevOps/WebsiteStaging(m).png?raw=true) | DevOps/WebsiteStaging.puml
DevOps | WebTest </br> (Web Test) | ![WebTest](dist/DevOps/WebTest.png?raw=true) | ![WebTest](dist/DevOps/WebTest(m).png?raw=true) | DevOps/WebTest.puml
**General** | | | | **General/all.puml**
General | AllResources </br> (All Resources) | ![AllResources](dist/General/AllResources.png?raw=true) | ![AllResources](dist/General/AllResources(m).png?raw=true) | General/AllResources.puml
General | Backlog </br> (Backlog) | ![Backlog](dist/General/Backlog.png?raw=true) | ![Backlog](dist/General/Backlog(m).png?raw=true) | General/Backlog.puml
General | BizTalk </br> (Biz Talk) | ![BizTalk](dist/General/BizTalk.png?raw=true) | ![BizTalk](dist/General/BizTalk(m).png?raw=true) | General/BizTalk.puml
General | CostAlerts </br> (Cost Alerts) | ![CostAlerts](dist/General/CostAlerts.png?raw=true) | ![CostAlerts](dist/General/CostAlerts(m).png?raw=true) | General/CostAlerts.puml
General | CostAnalysis </br> (Cost Analysis) | ![CostAnalysis](dist/General/CostAnalysis.png?raw=true) | ![CostAnalysis](dist/General/CostAnalysis(m).png?raw=true) | General/CostAnalysis.puml
General | CostBudgets </br> (Cost Budgets) | ![CostBudgets](dist/General/CostBudgets.png?raw=true) | ![CostBudgets](dist/General/CostBudgets(m).png?raw=true) | General/CostBudgets.puml
General | CostManagement </br> (Cost Management) | ![CostManagement](dist/General/CostManagement.png?raw=true) | ![CostManagement](dist/General/CostManagement(m).png?raw=true) | General/CostManagement.puml
General | Counter </br> (Counter) | ![Counter](dist/General/Counter.png?raw=true) | ![Counter](dist/General/Counter(m).png?raw=true) | General/Counter.puml
General | Cubes </br> (Cubes) | ![Cubes](dist/General/Cubes.png?raw=true) | ![Cubes](dist/General/Cubes(m).png?raw=true) | General/Cubes.puml
General | Dashboard </br> (Dashboard) | ![Dashboard](dist/General/Dashboard.png?raw=true) | ![Dashboard](dist/General/Dashboard(m).png?raw=true) | General/Dashboard.puml
General | DevConsole </br> (Dev Console) | ![DevConsole](dist/General/DevConsole.png?raw=true) | ![DevConsole](dist/General/DevConsole(m).png?raw=true) | General/DevConsole.puml
General | Download </br> (Download) | ![Download](dist/General/Download.png?raw=true) | ![Download](dist/General/Download(m).png?raw=true) | General/Download.puml
General | Error </br> (Error) | ![Error](dist/General/Error.png?raw=true) | ![Error](dist/General/Error(m).png?raw=true) | General/Error.puml
General | Extensions </br> (Extensions) | ![Extensions](dist/General/Extensions.png?raw=true) | ![Extensions](dist/General/Extensions(m).png?raw=true) | General/Extensions.puml
General | File </br> (File) | ![File](dist/General/File.png?raw=true) | ![File](dist/General/File(m).png?raw=true) | General/File.puml
General | Files </br> (Files) | ![Files](dist/General/Files.png?raw=true) | ![Files](dist/General/Files(m).png?raw=true) | General/Files.puml
General | FolderBlank </br> (Folder Blank) | ![FolderBlank](dist/General/FolderBlank.png?raw=true) | ![FolderBlank](dist/General/FolderBlank(m).png?raw=true) | General/FolderBlank.puml
General | FolderWebsite </br> (Folder Website) | ![FolderWebsite](dist/General/FolderWebsite.png?raw=true) | ![FolderWebsite](dist/General/FolderWebsite(m).png?raw=true) | General/FolderWebsite.puml
General | FTP </br> (FTP) | ![FTP](dist/General/FTP.png?raw=true) | ![FTP](dist/General/FTP(m).png?raw=true) | General/FTP.puml
General | Gear </br> (Gear) | ![Gear](dist/General/Gear.png?raw=true) | ![Gear](dist/General/Gear(m).png?raw=true) | General/Gear.puml
General | Globe </br> (Globe) | ![Globe](dist/General/Globe.png?raw=true) | ![Globe](dist/General/Globe(m).png?raw=true) | General/Globe.puml
General | GlobeError </br> (Globe Error) | ![GlobeError](dist/General/GlobeError.png?raw=true) | ![GlobeError](dist/General/GlobeError(m).png?raw=true) | General/GlobeError.puml
General | GlobeSuccess </br> (Globe Success) | ![GlobeSuccess](dist/General/GlobeSuccess.png?raw=true) | ![GlobeSuccess](dist/General/GlobeSuccess(m).png?raw=true) | General/GlobeSuccess.puml
General | GlobeWarning </br> (Globe Warning) | ![GlobeWarning](dist/General/GlobeWarning.png?raw=true) | ![GlobeWarning](dist/General/GlobeWarning(m).png?raw=true) | General/GlobeWarning.puml
General | Guide </br> (Guide) | ![Guide](dist/General/Guide.png?raw=true) | ![Guide](dist/General/Guide(m).png?raw=true) | General/Guide.puml
General | Heart </br> (Heart) | ![Heart](dist/General/Heart.png?raw=true) | ![Heart](dist/General/Heart(m).png?raw=true) | General/Heart.puml
General | HelpandSupport </br> (Helpand Support) | ![HelpandSupport](dist/General/HelpandSupport.png?raw=true) | ![HelpandSupport](dist/General/HelpandSupport(m).png?raw=true) | General/HelpandSupport.puml
General | Image </br> (Image) | ![Image](dist/General/Image.png?raw=true) | ![Image](dist/General/Image(m).png?raw=true) | General/Image.puml
General | Information </br> (Information) | ![Information](dist/General/Information.png?raw=true) | ![Information](dist/General/Information(m).png?raw=true) | General/Information.puml
General | InputOutput </br> (Input Output) | ![InputOutput](dist/General/InputOutput.png?raw=true) | ![InputOutput](dist/General/InputOutput(m).png?raw=true) | General/InputOutput.puml
General | JourneyHub </br> (Journey Hub) | ![JourneyHub](dist/General/JourneyHub.png?raw=true) | ![JourneyHub](dist/General/JourneyHub(m).png?raw=true) | General/JourneyHub.puml
General | LaunchPortal </br> (Launch Portal) | ![LaunchPortal](dist/General/LaunchPortal.png?raw=true) | ![LaunchPortal](dist/General/LaunchPortal(m).png?raw=true) | General/LaunchPortal.puml
General | Learn </br> (Learn) | ![Learn](dist/General/Learn.png?raw=true) | ![Learn](dist/General/Learn(m).png?raw=true) | General/Learn.puml
General | Location </br> (Location) | ![Location](dist/General/Location.png?raw=true) | ![Location](dist/General/Location(m).png?raw=true) | General/Location.puml
General | LogStreaming </br> (Log Streaming) | ![LogStreaming](dist/General/LogStreaming.png?raw=true) | ![LogStreaming](dist/General/LogStreaming(m).png?raw=true) | General/LogStreaming.puml
General | ManagementPortal </br> (Management Portal) | ![ManagementPortal](dist/General/ManagementPortal.png?raw=true) | ![ManagementPortal](dist/General/ManagementPortal(m).png?raw=true) | General/ManagementPortal.puml
General | Marketplace </br> (Marketplace) | ![Marketplace](dist/General/Marketplace.png?raw=true) | ![Marketplace](dist/General/Marketplace(m).png?raw=true) | General/Marketplace.puml
General | Media </br> (Media) | ![Media](dist/General/Media.png?raw=true) | ![Media](dist/General/Media(m).png?raw=true) | General/Media.puml
General | MediaFile </br> (Media File) | ![MediaFile](dist/General/MediaFile.png?raw=true) | ![MediaFile](dist/General/MediaFile(m).png?raw=true) | General/MediaFile.puml
General | Mobile </br> (Mobile) | ![Mobile](dist/General/Mobile.png?raw=true) | ![Mobile](dist/General/Mobile(m).png?raw=true) | General/Mobile.puml
General | MobileEngagement </br> (Mobile Engagement) | ![MobileEngagement](dist/General/MobileEngagement.png?raw=true) | ![MobileEngagement](dist/General/MobileEngagement(m).png?raw=true) | General/MobileEngagement.puml
General | Module </br> (Module) | ![Module](dist/General/Module.png?raw=true) | ![Module](dist/General/Module(m).png?raw=true) | General/Module.puml
General | Power </br> (Power) | ![Power](dist/General/Power.png?raw=true) | ![Power](dist/General/Power(m).png?raw=true) | General/Power.puml
General | Powershell </br> (Powershell) | ![Powershell](dist/General/Powershell.png?raw=true) | ![Powershell](dist/General/Powershell(m).png?raw=true) | General/Powershell.puml
General | PowerUp </br> (Power Up) | ![PowerUp](dist/General/PowerUp.png?raw=true) | ![PowerUp](dist/General/PowerUp(m).png?raw=true) | General/PowerUp.puml
General | Preview </br> (Preview) | ![Preview](dist/General/Preview.png?raw=true) | ![Preview](dist/General/Preview(m).png?raw=true) | General/Preview.puml
General | ProcessExplorer </br> (Process Explorer) | ![ProcessExplorer](dist/General/ProcessExplorer.png?raw=true) | ![ProcessExplorer](dist/General/ProcessExplorer(m).png?raw=true) | General/ProcessExplorer.puml
General | ProductionReadyDatabase </br> (Production Ready Database) | ![ProductionReadyDatabase](dist/General/ProductionReadyDatabase.png?raw=true) | ![ProductionReadyDatabase](dist/General/ProductionReadyDatabase(m).png?raw=true) | General/ProductionReadyDatabase.puml
General | QuickstartCenter </br> (Quickstart Center) | ![QuickstartCenter](dist/General/QuickstartCenter.png?raw=true) | ![QuickstartCenter](dist/General/QuickstartCenter(m).png?raw=true) | General/QuickstartCenter.puml
General | Recent </br> (Recent) | ![Recent](dist/General/Recent.png?raw=true) | ![Recent](dist/General/Recent(m).png?raw=true) | General/Recent.puml
General | ResourceGroupList </br> (Resource Group List) | ![ResourceGroupList](dist/General/ResourceGroupList.png?raw=true) | ![ResourceGroupList](dist/General/ResourceGroupList(m).png?raw=true) | General/ResourceGroupList.puml
General | ResourceGroups </br> (Resource Groups) | ![ResourceGroups](dist/General/ResourceGroups.png?raw=true) | ![ResourceGroups](dist/General/ResourceGroups(m).png?raw=true) | General/ResourceGroups.puml
General | ResourceLinked </br> (Resource Linked) | ![ResourceLinked](dist/General/ResourceLinked.png?raw=true) | ![ResourceLinked](dist/General/ResourceLinked(m).png?raw=true) | General/ResourceLinked.puml
General | Scale </br> (Scale) | ![Scale](dist/General/Scale.png?raw=true) | ![Scale](dist/General/Scale(m).png?raw=true) | General/Scale.puml
General | Scheduler </br> (Scheduler) | ![Scheduler](dist/General/Scheduler.png?raw=true) | ![Scheduler](dist/General/Scheduler(m).png?raw=true) | General/Scheduler.puml
General | SearchGrid </br> (Search Grid) | ![SearchGrid](dist/General/SearchGrid.png?raw=true) | ![SearchGrid](dist/General/SearchGrid(m).png?raw=true) | General/SearchGrid.puml
General | ServerFarm </br> (Server Farm) | ![ServerFarm](dist/General/ServerFarm.png?raw=true) | ![ServerFarm](dist/General/ServerFarm(m).png?raw=true) | General/ServerFarm.puml
General | ServiceHealth </br> (Service Health) | ![ServiceHealth](dist/General/ServiceHealth.png?raw=true) | ![ServiceHealth](dist/General/ServiceHealth(m).png?raw=true) | General/ServiceHealth.puml
General | Subscriptions </br> (Subscriptions) | ![Subscriptions](dist/General/Subscriptions.png?raw=true) | ![Subscriptions](dist/General/Subscriptions(m).png?raw=true) | General/Subscriptions.puml
General | Tags </br> (Tags) | ![Tags](dist/General/Tags.png?raw=true) | ![Tags](dist/General/Tags(m).png?raw=true) | General/Tags.puml
General | Toolbox </br> (Toolbox) | ![Toolbox](dist/General/Toolbox.png?raw=true) | ![Toolbox](dist/General/Toolbox(m).png?raw=true) | General/Toolbox.puml
General | Workbooks </br> (Workbooks) | ![Workbooks](dist/General/Workbooks.png?raw=true) | ![Workbooks](dist/General/Workbooks(m).png?raw=true) | General/Workbooks.puml
General | Workflow </br> (Workflow) | ![Workflow](dist/General/Workflow.png?raw=true) | ![Workflow](dist/General/Workflow(m).png?raw=true) | General/Workflow.puml
**Identity** | | | | **Identity/all.puml**
Identity | AppRegistrations </br> (App Registrations) | ![AppRegistrations](dist/Identity/AppRegistrations.png?raw=true) | ![AppRegistrations](dist/Identity/AppRegistrations(m).png?raw=true) | Identity/AppRegistrations.puml
Identity | AzureActiveDirectory </br> (Azure Active Directory) | ![AzureActiveDirectory](dist/Identity/AzureActiveDirectory.png?raw=true) | ![AzureActiveDirectory](dist/Identity/AzureActiveDirectory(m).png?raw=true) | Identity/AzureActiveDirectory.puml
Identity | AzureADDomainServices </br> (Azure ADDomain Services) | ![AzureADDomainServices](dist/Identity/AzureADDomainServices.png?raw=true) | ![AzureADDomainServices](dist/Identity/AzureADDomainServices(m).png?raw=true) | Identity/AzureADDomainServices.puml
Identity | EnterpriseApplications </br> (Enterprise Applications) | ![EnterpriseApplications](dist/Identity/EnterpriseApplications.png?raw=true) | ![EnterpriseApplications](dist/Identity/EnterpriseApplications(m).png?raw=true) | Identity/EnterpriseApplications.puml
Identity | Groups </br> (Groups) | ![Groups](dist/Identity/Groups.png?raw=true) | ![Groups](dist/Identity/Groups(m).png?raw=true) | Identity/Groups.puml
Identity | IdentityGovernance </br> (Identity Governance) | ![IdentityGovernance](dist/Identity/IdentityGovernance.png?raw=true) | ![IdentityGovernance](dist/Identity/IdentityGovernance(m).png?raw=true) | Identity/IdentityGovernance.puml
Identity | Users </br> (Users) | ![Users](dist/Identity/Users.png?raw=true) | ![Users](dist/Identity/Users(m).png?raw=true) | Identity/Users.puml
**Integration** | | | | **Integration/all.puml**
Integration | APIManagementServices </br> (A PIManagement Services) | ![APIManagementServices](dist/Integration/APIManagementServices.png?raw=true) | ![APIManagementServices](dist/Integration/APIManagementServices(m).png?raw=true) | Integration/APIManagementServices.puml
Integration | AzureDataCatalog </br> (Azure Data Catalog) | ![AzureDataCatalog](dist/Integration/AzureDataCatalog.png?raw=true) | ![AzureDataCatalog](dist/Integration/AzureDataCatalog(m).png?raw=true) | Integration/AzureDataCatalog.puml
Integration | DataFactory </br> (Data Factory) | ![DataFactory](dist/Integration/DataFactory.png?raw=true) | ![DataFactory](dist/Integration/DataFactory(m).png?raw=true) | Integration/DataFactory.puml
Integration | EventGridDomains </br> (Event Grid Domains) | ![EventGridDomains](dist/Integration/EventGridDomains.png?raw=true) | ![EventGridDomains](dist/Integration/EventGridDomains(m).png?raw=true) | Integration/EventGridDomains.puml
Integration | EventGridSubscriptions </br> (Event Grid Subscriptions) | ![EventGridSubscriptions](dist/Integration/EventGridSubscriptions.png?raw=true) | ![EventGridSubscriptions](dist/Integration/EventGridSubscriptions(m).png?raw=true) | Integration/EventGridSubscriptions.puml
Integration | EventGridTopics </br> (Event Grid Topics) | ![EventGridTopics](dist/Integration/EventGridTopics.png?raw=true) | ![EventGridTopics](dist/Integration/EventGridTopics(m).png?raw=true) | Integration/EventGridTopics.puml
Integration | EventHubClusters </br> (Event Hub Clusters) | ![EventHubClusters](dist/Integration/EventHubClusters.png?raw=true) | ![EventHubClusters](dist/Integration/EventHubClusters(m).png?raw=true) | Integration/EventHubClusters.puml
Integration | EventHubs </br> (Event Hubs) | ![EventHubs](dist/Integration/EventHubs.png?raw=true) | ![EventHubs](dist/Integration/EventHubs(m).png?raw=true) | Integration/EventHubs.puml
Integration | IntegrationAccounts </br> (Integration Accounts) | ![IntegrationAccounts](dist/Integration/IntegrationAccounts.png?raw=true) | ![IntegrationAccounts](dist/Integration/IntegrationAccounts(m).png?raw=true) | Integration/IntegrationAccounts.puml
Integration | LogicApps </br> (Logic Apps) | ![LogicApps](dist/Integration/LogicApps.png?raw=true) | ![LogicApps](dist/Integration/LogicApps(m).png?raw=true) | Integration/LogicApps.puml
Integration | Relays </br> (Relays) | ![Relays](dist/Integration/Relays.png?raw=true) | ![Relays](dist/Integration/Relays(m).png?raw=true) | Integration/Relays.puml
Integration | ServiceBus </br> (Service Bus) | ![ServiceBus](dist/Integration/ServiceBus.png?raw=true) | ![ServiceBus](dist/Integration/ServiceBus(m).png?raw=true) | Integration/ServiceBus.puml
Integration | SQLDataWarehouses </br> (S QLData Warehouses) | ![SQLDataWarehouses](dist/Integration/SQLDataWarehouses.png?raw=true) | ![SQLDataWarehouses](dist/Integration/SQLDataWarehouses(m).png?raw=true) | Integration/SQLDataWarehouses.puml
**IoT** | | | | **IoT/all.puml**
IoT | IoTCentralApplications </br> (IoT Central Applications) | ![IoTCentralApplications](dist/IoT/IoTCentralApplications.png?raw=true) | ![IoTCentralApplications](dist/IoT/IoTCentralApplications(m).png?raw=true) | IoT/IoTCentralApplications.puml
IoT | IoTEdge </br> (IoT Edge) | ![IoTEdge](dist/IoT/IoTEdge.png?raw=true) | ![IoTEdge](dist/IoT/IoTEdge(m).png?raw=true) | IoT/IoTEdge.puml
IoT | IoTHub </br> (IoT Hub) | ![IoTHub](dist/IoT/IoTHub.png?raw=true) | ![IoTHub](dist/IoT/IoTHub(m).png?raw=true) | IoT/IoTHub.puml
IoT | LogicApps </br> (Logic Apps) | ![LogicApps](dist/IoT/LogicApps.png?raw=true) | ![LogicApps](dist/IoT/LogicApps(m).png?raw=true) | IoT/LogicApps.puml
IoT | StreamAnalyticsJobs </br> (Stream Analytics Jobs) | ![StreamAnalyticsJobs](dist/IoT/StreamAnalyticsJobs.png?raw=true) | ![StreamAnalyticsJobs](dist/IoT/StreamAnalyticsJobs(m).png?raw=true) | IoT/StreamAnalyticsJobs.puml
**ManagementGovernance** | | | | **ManagementGovernance/all.puml**
ManagementGovernance | Advisor </br> (Advisor) | ![Advisor](dist/ManagementGovernance/Advisor.png?raw=true) | ![Advisor](dist/ManagementGovernance/Advisor(m).png?raw=true) | ManagementGovernance/Advisor.puml
ManagementGovernance | Alerts </br> (Alerts) | ![Alerts](dist/ManagementGovernance/Alerts.png?raw=true) | ![Alerts](dist/ManagementGovernance/Alerts(m).png?raw=true) | ManagementGovernance/Alerts.puml
ManagementGovernance | ApplicationInsights </br> (Application Insights) | ![ApplicationInsights](dist/ManagementGovernance/ApplicationInsights.png?raw=true) | ![ApplicationInsights](dist/ManagementGovernance/ApplicationInsights(m).png?raw=true) | ManagementGovernance/ApplicationInsights.puml
ManagementGovernance | AutomationAccounts </br> (Automation Accounts) | ![AutomationAccounts](dist/ManagementGovernance/AutomationAccounts.png?raw=true) | ![AutomationAccounts](dist/ManagementGovernance/AutomationAccounts(m).png?raw=true) | ManagementGovernance/AutomationAccounts.puml
ManagementGovernance | AzureArc </br> (Azure Arc) | ![AzureArc](dist/ManagementGovernance/AzureArc.png?raw=true) | ![AzureArc](dist/ManagementGovernance/AzureArc(m).png?raw=true) | ManagementGovernance/AzureArc.puml
ManagementGovernance | AzureLighthouse </br> (Azure Lighthouse) | ![AzureLighthouse](dist/ManagementGovernance/AzureLighthouse.png?raw=true) | ![AzureLighthouse](dist/ManagementGovernance/AzureLighthouse(m).png?raw=true) | ManagementGovernance/AzureLighthouse.puml
ManagementGovernance | Blueprints </br> (Blueprints) | ![Blueprints](dist/ManagementGovernance/Blueprints.png?raw=true) | ![Blueprints](dist/ManagementGovernance/Blueprints(m).png?raw=true) | ManagementGovernance/Blueprints.puml
ManagementGovernance | DiagnosticsSettings </br> (Diagnostics Settings) | ![DiagnosticsSettings](dist/ManagementGovernance/DiagnosticsSettings.png?raw=true) | ![DiagnosticsSettings](dist/ManagementGovernance/DiagnosticsSettings(m).png?raw=true) | ManagementGovernance/DiagnosticsSettings.puml
ManagementGovernance | Education </br> (Education) | ![Education](dist/ManagementGovernance/Education.png?raw=true) | ![Education](dist/ManagementGovernance/Education(m).png?raw=true) | ManagementGovernance/Education.puml
ManagementGovernance | LogAnalyticsWorkspaces </br> (Log Analytics Workspaces) | ![LogAnalyticsWorkspaces](dist/ManagementGovernance/LogAnalyticsWorkspaces.png?raw=true) | ![LogAnalyticsWorkspaces](dist/ManagementGovernance/LogAnalyticsWorkspaces(m).png?raw=true) | ManagementGovernance/LogAnalyticsWorkspaces.puml
ManagementGovernance | MachinesAzureArc </br> (Machines Azure Arc) | ![MachinesAzureArc](dist/ManagementGovernance/MachinesAzureArc.png?raw=true) | ![MachinesAzureArc](dist/ManagementGovernance/MachinesAzureArc(m).png?raw=true) | ManagementGovernance/MachinesAzureArc.puml
ManagementGovernance | ManagedApplicationsCenter </br> (Managed Applications Center) | ![ManagedApplicationsCenter](dist/ManagementGovernance/ManagedApplicationsCenter.png?raw=true) | ![ManagedApplicationsCenter](dist/ManagementGovernance/ManagedApplicationsCenter(m).png?raw=true) | ManagementGovernance/ManagedApplicationsCenter.puml
ManagementGovernance | ManagementGroups </br> (Management Groups) | ![ManagementGroups](dist/ManagementGovernance/ManagementGroups.png?raw=true) | ![ManagementGroups](dist/ManagementGovernance/ManagementGroups(m).png?raw=true) | ManagementGovernance/ManagementGroups.puml
ManagementGovernance | Metrics </br> (Metrics) | ![Metrics](dist/ManagementGovernance/Metrics.png?raw=true) | ![Metrics](dist/ManagementGovernance/Metrics(m).png?raw=true) | ManagementGovernance/Metrics.puml
ManagementGovernance | Monitor </br> (Monitor) | ![Monitor](dist/ManagementGovernance/Monitor.png?raw=true) | ![Monitor](dist/ManagementGovernance/Monitor(m).png?raw=true) | ManagementGovernance/Monitor.puml
ManagementGovernance | MyCustomers </br> (My Customers) | ![MyCustomers](dist/ManagementGovernance/MyCustomers.png?raw=true) | ![MyCustomers](dist/ManagementGovernance/MyCustomers(m).png?raw=true) | ManagementGovernance/MyCustomers.puml
ManagementGovernance | NetworkWatcher </br> (Network Watcher) | ![NetworkWatcher](dist/ManagementGovernance/NetworkWatcher.png?raw=true) | ![NetworkWatcher](dist/ManagementGovernance/NetworkWatcher(m).png?raw=true) | ManagementGovernance/NetworkWatcher.puml
ManagementGovernance | OperationLog(Classic) </br> (Operation Log( Classic)) | ![OperationLog(Classic)](dist/ManagementGovernance/OperationLog(Classic).png?raw=true) | ![OperationLog(Classic)](dist/ManagementGovernance/OperationLog(Classic)(m).png?raw=true) | ManagementGovernance/OperationLog(Classic).puml
ManagementGovernance | Policy </br> (Policy) | ![Policy](dist/ManagementGovernance/Policy.png?raw=true) | ![Policy](dist/ManagementGovernance/Policy(m).png?raw=true) | ManagementGovernance/Policy.puml
ManagementGovernance | ResourceGraphExplorer </br> (Resource Graph Explorer) | ![ResourceGraphExplorer](dist/ManagementGovernance/ResourceGraphExplorer.png?raw=true) | ![ResourceGraphExplorer](dist/ManagementGovernance/ResourceGraphExplorer(m).png?raw=true) | ManagementGovernance/ResourceGraphExplorer.puml
ManagementGovernance | ServiceProviders </br> (Service Providers) | ![ServiceProviders](dist/ManagementGovernance/ServiceProviders.png?raw=true) | ![ServiceProviders](dist/ManagementGovernance/ServiceProviders(m).png?raw=true) | ManagementGovernance/ServiceProviders.puml
ManagementGovernance | Solutions </br> (Solutions) | ![Solutions](dist/ManagementGovernance/Solutions.png?raw=true) | ![Solutions](dist/ManagementGovernance/Solutions(m).png?raw=true) | ManagementGovernance/Solutions.puml
ManagementGovernance | UserPrivacy </br> (User Privacy) | ![UserPrivacy](dist/ManagementGovernance/UserPrivacy.png?raw=true) | ![UserPrivacy](dist/ManagementGovernance/UserPrivacy(m).png?raw=true) | ManagementGovernance/UserPrivacy.puml
**Migrate** | | | | **Migrate/all.puml**
Migrate | DataBox </br> (Data Box) | ![DataBox](dist/Migrate/DataBox.png?raw=true) | ![DataBox](dist/Migrate/DataBox(m).png?raw=true) | Migrate/DataBox.puml
Migrate | DataBoxEdge </br> (Data Box Edge) | ![DataBoxEdge](dist/Migrate/DataBoxEdge.png?raw=true) | ![DataBoxEdge](dist/Migrate/DataBoxEdge(m).png?raw=true) | Migrate/DataBoxEdge.puml
**MixedReality** | | | | **MixedReality/all.puml**
MixedReality | RemoteRendering </br> (Remote Rendering) | ![RemoteRendering](dist/MixedReality/RemoteRendering.png?raw=true) | ![RemoteRendering](dist/MixedReality/RemoteRendering(m).png?raw=true) | MixedReality/RemoteRendering.puml
**Networking** | | | | **Networking/all.puml**
Networking | ApplicationSecurityGroups </br> (Application Security Groups) | ![ApplicationSecurityGroups](dist/Networking/ApplicationSecurityGroups.png?raw=true) | ![ApplicationSecurityGroups](dist/Networking/ApplicationSecurityGroups(m).png?raw=true) | Networking/ApplicationSecurityGroups.puml
Networking | AzureFirewallManager </br> (Azure Firewall Manager) | ![AzureFirewallManager](dist/Networking/AzureFirewallManager.png?raw=true) | ![AzureFirewallManager](dist/Networking/AzureFirewallManager(m).png?raw=true) | Networking/AzureFirewallManager.puml
Networking | Bastion </br> (Bastion) | ![Bastion](dist/Networking/Bastion.png?raw=true) | ![Bastion](dist/Networking/Bastion(m).png?raw=true) | Networking/Bastion.puml
Networking | Connections </br> (Connections) | ![Connections](dist/Networking/Connections.png?raw=true) | ![Connections](dist/Networking/Connections(m).png?raw=true) | Networking/Connections.puml
Networking | DDoSProtectionPlans </br> (D DoS Protection Plans) | ![DDoSProtectionPlans](dist/Networking/DDoSProtectionPlans.png?raw=true) | ![DDoSProtectionPlans](dist/Networking/DDoSProtectionPlans(m).png?raw=true) | Networking/DDoSProtectionPlans.puml
Networking | DNSZones </br> (D NSZones) | ![DNSZones](dist/Networking/DNSZones.png?raw=true) | ![DNSZones](dist/Networking/DNSZones(m).png?raw=true) | Networking/DNSZones.puml
Networking | ExpressRouteCircuits </br> (Express Route Circuits) | ![ExpressRouteCircuits](dist/Networking/ExpressRouteCircuits.png?raw=true) | ![ExpressRouteCircuits](dist/Networking/ExpressRouteCircuits(m).png?raw=true) | Networking/ExpressRouteCircuits.puml
Networking | FrontDoors </br> (Front Doors) | ![FrontDoors](dist/Networking/FrontDoors.png?raw=true) | ![FrontDoors](dist/Networking/FrontDoors(m).png?raw=true) | Networking/FrontDoors.puml
Networking | LoadBalancers </br> (Load Balancers) | ![LoadBalancers](dist/Networking/LoadBalancers.png?raw=true) | ![LoadBalancers](dist/Networking/LoadBalancers(m).png?raw=true) | Networking/LoadBalancers.puml
Networking | NAT </br> (NAT) | ![NAT](dist/Networking/NAT.png?raw=true) | ![NAT](dist/Networking/NAT(m).png?raw=true) | Networking/NAT.puml
Networking | NetworkInterfaces </br> (Network Interfaces) | ![NetworkInterfaces](dist/Networking/NetworkInterfaces.png?raw=true) | ![NetworkInterfaces](dist/Networking/NetworkInterfaces(m).png?raw=true) | Networking/NetworkInterfaces.puml
Networking | NetworkSecurityGroups </br> (Network Security Groups) | ![NetworkSecurityGroups](dist/Networking/NetworkSecurityGroups.png?raw=true) | ![NetworkSecurityGroups](dist/Networking/NetworkSecurityGroups(m).png?raw=true) | Networking/NetworkSecurityGroups.puml
Networking | NetworkWatcher </br> (Network Watcher) | ![NetworkWatcher](dist/Networking/NetworkWatcher.png?raw=true) | ![NetworkWatcher](dist/Networking/NetworkWatcher(m).png?raw=true) | Networking/NetworkWatcher.puml
Networking | PrivateLink </br> (Private Link) | ![PrivateLink](dist/Networking/PrivateLink.png?raw=true) | ![PrivateLink](dist/Networking/PrivateLink(m).png?raw=true) | Networking/PrivateLink.puml
Networking | PrivateLinkService </br> (Private Link Service) | ![PrivateLinkService](dist/Networking/PrivateLinkService.png?raw=true) | ![PrivateLinkService](dist/Networking/PrivateLinkService(m).png?raw=true) | Networking/PrivateLinkService.puml
Networking | ProximityPlacementGroups </br> (Proximity Placement Groups) | ![ProximityPlacementGroups](dist/Networking/ProximityPlacementGroups.png?raw=true) | ![ProximityPlacementGroups](dist/Networking/ProximityPlacementGroups(m).png?raw=true) | Networking/ProximityPlacementGroups.puml
Networking | PublicIPAddresses </br> (Public IPAddresses) | ![PublicIPAddresses](dist/Networking/PublicIPAddresses.png?raw=true) | ![PublicIPAddresses](dist/Networking/PublicIPAddresses(m).png?raw=true) | Networking/PublicIPAddresses.puml
Networking | PublicIPPrefixes </br> (Public IPPrefixes) | ![PublicIPPrefixes](dist/Networking/PublicIPPrefixes.png?raw=true) | ![PublicIPPrefixes](dist/Networking/PublicIPPrefixes(m).png?raw=true) | Networking/PublicIPPrefixes.puml
Networking | ReservedIPAddresses(Classic) </br> (Reserved IPAddresses( Classic)) | ![ReservedIPAddresses(Classic)](dist/Networking/ReservedIPAddresses(Classic).png?raw=true) | ![ReservedIPAddresses(Classic)](dist/Networking/ReservedIPAddresses(Classic)(m).png?raw=true) | Networking/ReservedIPAddresses(Classic).puml
Networking | RouteFilters </br> (Route Filters) | ![RouteFilters](dist/Networking/RouteFilters.png?raw=true) | ![RouteFilters](dist/Networking/RouteFilters(m).png?raw=true) | Networking/RouteFilters.puml
Networking | ServiceEndpointPolicies </br> (Service Endpoint Policies) | ![ServiceEndpointPolicies](dist/Networking/ServiceEndpointPolicies.png?raw=true) | ![ServiceEndpointPolicies](dist/Networking/ServiceEndpointPolicies(m).png?raw=true) | Networking/ServiceEndpointPolicies.puml
Networking | TrafficManagerProfiles </br> (Traffic Manager Profiles) | ![TrafficManagerProfiles](dist/Networking/TrafficManagerProfiles.png?raw=true) | ![TrafficManagerProfiles](dist/Networking/TrafficManagerProfiles(m).png?raw=true) | Networking/TrafficManagerProfiles.puml
Networking | VirtualNetworkGateways </br> (Virtual Network Gateways) | ![VirtualNetworkGateways](dist/Networking/VirtualNetworkGateways.png?raw=true) | ![VirtualNetworkGateways](dist/Networking/VirtualNetworkGateways(m).png?raw=true) | Networking/VirtualNetworkGateways.puml
Networking | VirtualNetworks </br> (Virtual Networks) | ![VirtualNetworks](dist/Networking/VirtualNetworks.png?raw=true) | ![VirtualNetworks](dist/Networking/VirtualNetworks(m).png?raw=true) | Networking/VirtualNetworks.puml
Networking | WebApplicationFirewallPolicies(WAF) </br> (Web Application Firewall Policies( WAF)) | ![WebApplicationFirewallPolicies(WAF)](dist/Networking/WebApplicationFirewallPolicies(WAF).png?raw=true) | ![WebApplicationFirewallPolicies(WAF)](dist/Networking/WebApplicationFirewallPolicies(WAF)(m).png?raw=true) | Networking/WebApplicationFirewallPolicies(WAF).puml
**Other** | | | | **Other/all.puml**
Other | ApplicationGateways </br> (Application Gateways) | ![ApplicationGateways](dist/Other/ApplicationGateways.png?raw=true) | ![ApplicationGateways](dist/Other/ApplicationGateways(m).png?raw=true) | Other/ApplicationGateways.puml
Other | AzureMaps </br> (Azure Maps) | ![AzureMaps](dist/Other/AzureMaps.png?raw=true) | ![AzureMaps](dist/Other/AzureMaps(m).png?raw=true) | Other/AzureMaps.puml
Other | Detonation </br> (Detonation) | ![Detonation](dist/Other/Detonation.png?raw=true) | ![Detonation](dist/Other/Detonation(m).png?raw=true) | Other/Detonation.puml
Other | DiskEncryptionSets </br> (Disk Encryption Sets) | ![DiskEncryptionSets](dist/Other/DiskEncryptionSets.png?raw=true) | ![DiskEncryptionSets](dist/Other/DiskEncryptionSets(m).png?raw=true) | Other/DiskEncryptionSets.puml
Other | Firewalls </br> (Firewalls) | ![Firewalls](dist/Other/Firewalls.png?raw=true) | ![Firewalls](dist/Other/Firewalls(m).png?raw=true) | Other/Firewalls.puml
Other | InstancePools </br> (Instance Pools) | ![InstancePools](dist/Other/InstancePools.png?raw=true) | ![InstancePools](dist/Other/InstancePools(m).png?raw=true) | Other/InstancePools.puml
Other | InternetAnalyzerProfiles </br> (Internet Analyzer Profiles) | ![InternetAnalyzerProfiles](dist/Other/InternetAnalyzerProfiles.png?raw=true) | ![InternetAnalyzerProfiles](dist/Other/InternetAnalyzerProfiles(m).png?raw=true) | Other/InternetAnalyzerProfiles.puml
Other | IPGroups </br> (IP Groups) | ![IPGroups](dist/Other/IPGroups.png?raw=true) | ![IPGroups](dist/Other/IPGroups(m).png?raw=true) | Other/IPGroups.puml
Other | ManagedApplications </br> (Managed Applications) | ![ManagedApplications](dist/Other/ManagedApplications.png?raw=true) | ![ManagedApplications](dist/Other/ManagedApplications(m).png?raw=true) | Other/ManagedApplications.puml
Other | NAT </br> (NAT) | ![NAT](dist/Other/NAT.png?raw=true) | ![NAT](dist/Other/NAT(m).png?raw=true) | Other/NAT.puml
Other | Reservations </br> (Reservations) | ![Reservations](dist/Other/Reservations.png?raw=true) | ![Reservations](dist/Other/Reservations(m).png?raw=true) | Other/Reservations.puml
Other | SiteRecovery </br> (Site Recovery) | ![SiteRecovery](dist/Other/SiteRecovery.png?raw=true) | ![SiteRecovery](dist/Other/SiteRecovery(m).png?raw=true) | Other/SiteRecovery.puml
**Preview** | | | | **Preview/all.puml**
Preview | AzureCloudShell </br> (Azure Cloud Shell) | ![AzureCloudShell](dist/Preview/AzureCloudShell.png?raw=true) | ![AzureCloudShell](dist/Preview/AzureCloudShell(m).png?raw=true) | Preview/AzureCloudShell.puml
Preview | PrivateLinkHub </br> (Private Link Hub) | ![PrivateLinkHub](dist/Preview/PrivateLinkHub.png?raw=true) | ![PrivateLinkHub](dist/Preview/PrivateLinkHub(m).png?raw=true) | Preview/PrivateLinkHub.puml
Preview | WebEnvironment </br> (Web Environment) | ![WebEnvironment](dist/Preview/WebEnvironment.png?raw=true) | ![WebEnvironment](dist/Preview/WebEnvironment(m).png?raw=true) | Preview/WebEnvironment.puml
**Security** | | | | **Security/all.puml**
Security | DedicatedHSM </br> (Dedicated HSM) | ![DedicatedHSM](dist/Security/DedicatedHSM.png?raw=true) | ![DedicatedHSM](dist/Security/DedicatedHSM(m).png?raw=true) | Security/DedicatedHSM.puml
Security | KeyVault </br> (Key Vault) | ![KeyVault](dist/Security/KeyVault.png?raw=true) | ![KeyVault](dist/Security/KeyVault(m).png?raw=true) | Security/KeyVault.puml
Security | Sentinel </br> (Sentinel) | ![Sentinel](dist/Security/Sentinel.png?raw=true) | ![Sentinel](dist/Security/Sentinel(m).png?raw=true) | Security/Sentinel.puml
**Storage** | | | | **Storage/all.puml**
Storage | AzureHCPCache </br> (Azure HCP Cache) | ![AzureHCPCache](dist/Storage/AzureHCPCache.png?raw=true) | ![AzureHCPCache](dist/Storage/AzureHCPCache(m).png?raw=true) | Storage/AzureHCPCache.puml
Storage | AzureNetAppFiles </br> (Azure Net App Files) | ![AzureNetAppFiles](dist/Storage/AzureNetAppFiles.png?raw=true) | ![AzureNetAppFiles](dist/Storage/AzureNetAppFiles(m).png?raw=true) | Storage/AzureNetAppFiles.puml
Storage | AzureStackEdge </br> (Azure Stack Edge) | ![AzureStackEdge](dist/Storage/AzureStackEdge.png?raw=true) | ![AzureStackEdge](dist/Storage/AzureStackEdge(m).png?raw=true) | Storage/AzureStackEdge.puml
Storage | DataBox </br> (Data Box) | ![DataBox](dist/Storage/DataBox.png?raw=true) | ![DataBox](dist/Storage/DataBox(m).png?raw=true) | Storage/DataBox.puml
Storage | DataBoxEdge </br> (Data Box Edge) | ![DataBoxEdge](dist/Storage/DataBoxEdge.png?raw=true) | ![DataBoxEdge](dist/Storage/DataBoxEdge(m).png?raw=true) | Storage/DataBoxEdge.puml
Storage | DataShareInvitations </br> (Data Share Invitations) | ![DataShareInvitations](dist/Storage/DataShareInvitations.png?raw=true) | ![DataShareInvitations](dist/Storage/DataShareInvitations(m).png?raw=true) | Storage/DataShareInvitations.puml
Storage | DataShares </br> (Data Shares) | ![DataShares](dist/Storage/DataShares.png?raw=true) | ![DataShares](dist/Storage/DataShares(m).png?raw=true) | Storage/DataShares.puml
Storage | ImportExportJobs </br> (Import Export Jobs) | ![ImportExportJobs](dist/Storage/ImportExportJobs.png?raw=true) | ![ImportExportJobs](dist/Storage/ImportExportJobs(m).png?raw=true) | Storage/ImportExportJobs.puml
Storage | RecoveryServicesVaults </br> (Recovery Services Vaults) | ![RecoveryServicesVaults](dist/Storage/RecoveryServicesVaults.png?raw=true) | ![RecoveryServicesVaults](dist/Storage/RecoveryServicesVaults(m).png?raw=true) | Storage/RecoveryServicesVaults.puml
Storage | SSD </br> (SSD) | ![SSD](dist/Storage/SSD.png?raw=true) | ![SSD](dist/Storage/SSD(m).png?raw=true) | Storage/SSD.puml
Storage | StorageAccounts </br> (Storage Accounts) | ![StorageAccounts](dist/Storage/StorageAccounts.png?raw=true) | ![StorageAccounts](dist/Storage/StorageAccounts(m).png?raw=true) | Storage/StorageAccounts.puml
Storage | StorageAzureFiles </br> (Storage Azure Files) | ![StorageAzureFiles](dist/Storage/StorageAzureFiles.png?raw=true) | ![StorageAzureFiles](dist/Storage/StorageAzureFiles(m).png?raw=true) | Storage/StorageAzureFiles.puml
Storage | StorageBlobBlock </br> (Storage Blob Block) | ![StorageBlobBlock](dist/Storage/StorageBlobBlock.png?raw=true) | ![StorageBlobBlock](dist/Storage/StorageBlobBlock(m).png?raw=true) | Storage/StorageBlobBlock.puml
Storage | StorageBlobPage </br> (Storage Blob Page) | ![StorageBlobPage](dist/Storage/StorageBlobPage.png?raw=true) | ![StorageBlobPage](dist/Storage/StorageBlobPage(m).png?raw=true) | Storage/StorageBlobPage.puml
Storage | StorageQueue </br> (Storage Queue) | ![StorageQueue](dist/Storage/StorageQueue.png?raw=true) | ![StorageQueue](dist/Storage/StorageQueue(m).png?raw=true) | Storage/StorageQueue.puml
Storage | StorageTable </br> (Storage Table) | ![StorageTable](dist/Storage/StorageTable.png?raw=true) | ![StorageTable](dist/Storage/StorageTable(m).png?raw=true) | Storage/StorageTable.puml
Storage | StorSimpleDataManagers </br> (Stor Simple Data Managers) | ![StorSimpleDataManagers](dist/Storage/StorSimpleDataManagers.png?raw=true) | ![StorSimpleDataManagers](dist/Storage/StorSimpleDataManagers(m).png?raw=true) | Storage/StorSimpleDataManagers.puml
Storage | StorSimpleDeviceManagers </br> (Stor Simple Device Managers) | ![StorSimpleDeviceManagers](dist/Storage/StorSimpleDeviceManagers.png?raw=true) | ![StorSimpleDeviceManagers](dist/Storage/StorSimpleDeviceManagers(m).png?raw=true) | Storage/StorSimpleDeviceManagers.puml
**Web** | | | | **Web/all.puml**
Web | AzureMediaService </br> (Azure Media Service) | ![AzureMediaService](dist/Web/AzureMediaService.png?raw=true) | ![AzureMediaService](dist/Web/AzureMediaService(m).png?raw=true) | Web/AzureMediaService.puml
Web | CDNProfiles </br> (C DNProfiles) | ![CDNProfiles](dist/Web/CDNProfiles.png?raw=true) | ![CDNProfiles](dist/Web/CDNProfiles(m).png?raw=true) | Web/CDNProfiles.puml
Web | SearchServices </br> (Search Services) | ![SearchServices](dist/Web/SearchServices.png?raw=true) | ![SearchServices](dist/Web/SearchServices(m).png?raw=true) | Web/SearchServices.puml
Web | SignalRService </br> (SignalR Service) | ![SignalRService](dist/Web/SignalRService.png?raw=true) | ![SignalRService](dist/Web/SignalRService(m).png?raw=true) | Web/SignalRService.puml
Web | StaticWebApps </br> (Static Web Apps) | ![StaticWebApps](dist/Web/StaticWebApps.png?raw=true) | ![StaticWebApps](dist/Web/StaticWebApps(m).png?raw=true) | Web/StaticWebApps.puml
