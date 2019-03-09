<template>
    <div>
        <Card dis-hover>
            <div class="page-body">
                <Form ref="queryForm" :label-width="80" label-position="left" inline>
                    <Row :gutter="16">
                        <Col span="6">
                            <FormItem :label="L('Code')+':'" style="width:100%">
                                <Input v-model="pagerequest.code" :placeholder="L('Code')"></Input>
                            </FormItem>
                        </Col>
                        <Col span="6">
                            <FormItem :label="L('Brand')+':'" style="width:100%">
                                <Input v-model="pagerequest.keyword" :placeholder="L('Brand')"></Input>
                            </FormItem>
                        </Col>
                    </Row>
                    <Row>
                        <Button @click="create" icon="android-add" type="primary" size="large">{{L('Add')}}</Button>
                        <Button icon="ios-search" type="primary" size="large" @click="getpage" class="toolbar-btn">{{L('Find')}}</Button>
                    </Row>
                </Form>
                <div class="margin-top-10">
                    <Table :loading="loading" :columns="columns" :no-data-text="L('NoDatas')" border :data="list">
                    </Table>
                    <Page show-sizer class-name="fengpage" :total="totalCount" class="margin-top-10" @on-change="pageChange" @on-page-size-change="pagesizeChange" :page-size="pageSize" :current="currentPage" :show-elevator:="false"></Page>
                </div>
            </div>
        </Card>
    </div>
</template>
<script lang="ts">
    import { Component, Vue,Inject, Prop,Watch } from 'vue-property-decorator';
    import Util from '@/lib/util'
    import AbpBase from '@/lib/abpbase'
    import PageRequest from '@/store/entities/page-request';
    class  PageProductRequest extends PageRequest{
        code:string;
        branc:string
    }

    @Component({
        components:{}
    })
    export default class Products extends AbpBase{
        edit(){
            this.editModalShow=true;
        }
        //filters
        pagerequest:PageProductRequest=new PageProductRequest();

        createModalShow:boolean=false;
        editModalShow:boolean=false;
        get list(){
            return this.$store.state.product.list;
        };
        get loading(){
            return this.$store.state.product.loading;
        }
        create(){
            this.createModalShow=true;
        }
        pageChange(page:number){
            this.$store.commit('product/setCurrentPage',page);
            this.getpage();
        }
        pagesizeChange(pagesize:number){
            this.$store.commit('product/setPageSize',pagesize);
            this.getpage();
        }
        async getpage(){
          
            this.pagerequest.maxResultCount=this.pageSize;
            this.pagerequest.skipCount=(this.currentPage-1)*this.pageSize;
            //filters

            await this.$store.dispatch({
                type:'product/getAll',
                data:this.pagerequest
            })
        }
        get pageSize(){
            return this.$store.state.product.pageSize;
        }
        get totalCount(){
            return this.$store.state.product.totalCount;
        }
        get currentPage(){
            return this.$store.state.product.currentPage;
        }
        columns=[{
            title:this.L('Code'),
            key:'code'
        },{
            title:this.L('Description'),
            key:'description'
        },{
            title:this.L('Brand'),
            key:'brand'
        },{
            title:this.L('Price'),
            key:'price'
        },{
            title:this.L('Actions'),
            key:'Actions',
            width:150,
            render:(h:any,params:any)=>{
                return h('div',[
                    h('Button',{
                        props:{
                            type:'primary',
                            size:'small'
                        },
                        style:{
                            marginRight:'5px'
                        },
                        on:{
                            click:()=>{
                                this.$store.commit('product/edit',params.row);
                                this.edit();
                            }
                        }
                    },this.L('Edit')),
                    h('Button',{
                        props:{
                            type:'error',
                            size:'small'
                        },
                        on:{
                            click:async ()=>{
                                this.$Modal.confirm({
                                        title:this.L('Tips'),
                                        content:this.L('DeleteProductConfirm'),
                                        okText:this.L('Yes'),
                                        cancelText:this.L('No'),
                                        onOk:async()=>{
                                            await this.$store.dispatch({
                                                type:'product/delete',
                                                data:params.row
                                            })
                                            await this.getpage();
                                        }
                                })
                            }
                        }
                    },this.L('Delete'))
                ])
            }
        }]
        async created(){
            this.getpage();
            // await this.$store.dispatch({
            //     type:'product/getQuantity'
            // })
        }
    }
</script>