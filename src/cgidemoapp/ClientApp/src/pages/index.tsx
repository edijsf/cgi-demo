import React from "react";
import CategoryHeader from "../components/Category/CategoryHeader";
import CategoryTree from "../components/CategoryTree/CategoryTree";
import Main from "../components/Main/Main";
import Page from "../components/Page/Page";
import ProductsList from "../components/Products/ProductsList";
import ProductsSort from "../components/Products/ProductsSort";
import Sidebar from "../components/Sidebar/Sidebar";

interface Props {}

const index = (props: Props) => {
  return (
    <Page>
      <Sidebar>
        <CategoryTree />
      </Sidebar>
      <Main>
        <CategoryHeader />
        <ProductsSort />
        <ProductsList />
      </Main>
    </Page>
  );
};

export default index;
