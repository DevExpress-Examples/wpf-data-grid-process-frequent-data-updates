<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/297755792/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T933640)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to effectively process data updates in WPF GridControl

This example demonstrates three different techniques to handle frequent updates in GridControl:
1. Improving the speed of individual updates using the [ChunkList](https://docs.devexpress.com/WPF/DevExpress.Xpf.ChunkList.ChunkList-1) collection and the [optimized summaries](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.OptimizeSummaryCalculation) feature.
2. Wrapping data update batches in the BeginDataUpdate and EndDataUpdate methods calls. BeginDataUpdate locks GridControl, which allows you to execute multiple updates without refreshing GridControl on each update. In this example, we create a [custom MVVM service](https://docs.devexpress.com/WPF/16920/mvvm-framework/services/how-to-create-a-custom-service) to call these methods from the view model level: *GridUpdateService*
3. Periodic GridControl refresh using the [GridControl.RefreshData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.RefreshData) method. In order not to recalculate any information when a single update occurs, set [AllowLiveDataShaping](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.AllowLiveDataShaping) to false and use a collection that doesn't support notifications, e.g., List<t>. In this example, we create a [custom behavior](https://docs.devexpress.com/WPF/17458/mvvm-framework/behaviors/how-to-create-a-custom-behavior) to automatically refresh GridControl each second.
  
  The first technique is effective when the number of updates is much fewer than the source size. Note that it makes sense to use ChunkList only when the data source contains at least several thousand items. With smaller sources, it's more efficient to use only optimized summaries.
  
  The second and third techniques are useful when updates affect a significant part of your source. RefreshData and EndDataUpdate methods fully refresh GridControl (including sorting, filtering etc.), so refresh speed doesn't depend on how many data changes you make in one update batch. 
