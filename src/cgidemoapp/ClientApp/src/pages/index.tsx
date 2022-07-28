import React from "react";
import Main from "../components/Main";
import Page from "../components/Page";
import Sidebar from "../components/Sidebar";

interface Props {}

const index = (props: Props) => {
  return (
    <Page>
      <Sidebar></Sidebar>
      <Main></Main>
    </Page>
  );
};

export default index;
