<template>
  <div class="app-container">
    <div class="filter-container">
      <el-input
        v-model="listQuery.Name"
        placeholder="产品名称"
        style="width: 150px"
        size="small"
        class="filter-item"
        @keyup.enter.native="handleFilter"
      />
      <el-button
        class="filter-item"
        size="mini"
        type="success"
        icon="el-icon-search"
        @click="handleFilter"
        >搜索</el-button
      >
    </div>

    <el-table
      ref="table"
      v-loading="listLoading"
      :data="list"
      @sort-change="sortChange"
      style="width: 100%"
    >
      <el-table-column prop="name" label="产品名称" />
      <el-table-column prop="stock" label="库存数量" width="130px" />
      <el-table-column prop="creationTime" label="创建时间" width="180px">
        <template slot-scope="scope">
          <span>{{ scope.row.creationTime | formatDateTime }}</span>
        </template>
      </el-table-column>
    </el-table>
    <pagination
      v-show="totalCount > 0"
      :total="totalCount"
      :page.sync="page"
      :limit.sync="listQuery.MaxResultCount"
      @pagination="getList"
    />
  </div>
</template>

<script>
import Pagination from "@/components/Pagination";
import permission from "@/directive/permission/index.js";
import config from "../../../static/config";

export default {
  name: "product",
  components: { Pagination },
  data() {
    return {
      list: null,
      totalCount: 0,
      listLoading: true,
      createParam:{
  entryNo: "string2",
  storeAreaType: 0,
  arrivalDate: "2020-12-04",
  memo: "string",
  createEntryListInputs: [
    {
      entryId: "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      totalQuantity: 0,
      unitPrice: 0,
      orderCount: 0
    }
  ]
},
      listQuery: {
        Name: null,
        Sorting: null,
        SkipCount: 0,
        MaxResultCount: 10,
      },
      page: 1,
    };
  },
  created() {
    this.getList();
  },
  methods: {
    getList() {
      this.listLoading = true;
      this.listQuery.SkipCount = (this.page - 1) * 10;
      this.$axios
        // .gets("/api/Box/sample", this.listQuery)
        // .then((response) => {
        //   response.items.forEach((element) => {
        //     if (!element.lastModificationTime) {
        //       element.lastModificationTime = element.creationTime;
        //     }
        //   });
        .gets("/api/business/test", this.listQuery)
        .then((response) => {
          response.items.forEach((element) => {
            if (!element.lastModificationTime) {
              element.lastModificationTime = element.creationTime;
            }
          });
        // .posts("/api/wms/entry", this.createParam)
        //       .then((response) => {
        //         this.formLoading = false;
        //         this.$notify({
        //           title: "成功",
        //           message: "新增成功",
        //           type: "success",
        //           duration: 2000,
        //         });
          this.list = response.items;
          this.totalCount = response.totalCount;
          this.listLoading = false;
        });
    },
    handleFilter() {
      this.page = 1;
      this.getList();
    },
    sortChange(data) {
      const { prop, order } = data;
      if (!prop || !order) {
        this.handleFilter();
        return;
      }
      this.listQuery.Sorting = prop + " " + order;
      this.handleFilter();
    },
  },
};
</script>

<style>
.table-expand {
  font-size: 0;
}
.table-expand label {
  width: 70px;
  color: #99a9bf;
}
.table-expand .el-form-item {
  margin-right: 0;
  margin-bottom: 0;
  width: 100%;
}
.table-expand .el-form-item__content {
  font-size: 12px;
}
</style>