import React from "react";
import CategoryHeader from "../components/Category/CategoryHeader";
import Main from "../components/Main/Main";
import Page from "../components/Page/Page";
import ProductsList from "../components/Products/ProductsList";
import ProductsSort from "../components/Products/ProductsSort";
import Sidebar from "../components/Sidebar/Sidebar";

interface Props {}

const index = (props: Props) => {
  return (
    <Page>
      <Sidebar>side</Sidebar>
      <Main>
        <CategoryHeader />
        <ProductsSort />
        <ProductsList />
      </Main>
    </Page>
  );
};

export default index;
