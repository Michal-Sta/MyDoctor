/* prettier-ignore-start */

/* eslint-disable */

// @ts-nocheck

// noinspection JSUnusedGlobalSymbols

// This file is auto-generated by TanStack Router

import { createFileRoute } from '@tanstack/react-router'

// Import Routes

import { Route as rootRoute } from './routes/__root'

// Create Virtual Routes

const SearcherLazyImport = createFileRoute('/searcher')()
const ProfileLazyImport = createFileRoute('/profile')()
const AppointmentListLazyImport = createFileRoute('/appointment-list')()
const IndexLazyImport = createFileRoute('/')()

// Create/Update Routes

const SearcherLazyRoute = SearcherLazyImport.update({
  path: '/searcher',
  getParentRoute: () => rootRoute,
} as any).lazy(() => import('./routes/searcher.lazy').then((d) => d.Route))

const ProfileLazyRoute = ProfileLazyImport.update({
  path: '/profile',
  getParentRoute: () => rootRoute,
} as any).lazy(() => import('./routes/profile.lazy').then((d) => d.Route))

const AppointmentListLazyRoute = AppointmentListLazyImport.update({
  path: '/appointment-list',
  getParentRoute: () => rootRoute,
} as any).lazy(() =>
  import('./routes/appointment-list.lazy').then((d) => d.Route),
)

const IndexLazyRoute = IndexLazyImport.update({
  path: '/',
  getParentRoute: () => rootRoute,
} as any).lazy(() => import('./routes/index.lazy').then((d) => d.Route))

// Populate the FileRoutesByPath interface

declare module '@tanstack/react-router' {
  interface FileRoutesByPath {
    '/': {
      preLoaderRoute: typeof IndexLazyImport
      parentRoute: typeof rootRoute
    }
    '/appointment-list': {
      preLoaderRoute: typeof AppointmentListLazyImport
      parentRoute: typeof rootRoute
    }
    '/profile': {
      preLoaderRoute: typeof ProfileLazyImport
      parentRoute: typeof rootRoute
    }
    '/searcher': {
      preLoaderRoute: typeof SearcherLazyImport
      parentRoute: typeof rootRoute
    }
  }
}

// Create and export the route tree

export const routeTree = rootRoute.addChildren([
  IndexLazyRoute,
  AppointmentListLazyRoute,
  ProfileLazyRoute,
  SearcherLazyRoute,
])

/* prettier-ignore-end */
