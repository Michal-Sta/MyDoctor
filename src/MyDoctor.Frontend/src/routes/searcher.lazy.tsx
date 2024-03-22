import { createLazyFileRoute } from "@tanstack/react-router";
import React from "react";
import { SearchContainer } from "../components/search/searcher-container";

function Index() {
  return <SearchContainer />;
}

export const Route = createLazyFileRoute("/searcher")({
  component: Index,
});
