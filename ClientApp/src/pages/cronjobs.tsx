import React from 'react';
import DefaultLayout, { Clamp } from '../layout/layout';
import Head from '../components/Head';
import Hero from '../components/Hero';
import { useQuery } from 'react-query';
import { CronjobListDto } from '../api';
import { useTranslateApiError } from '../api';
import { Column } from 'react-table';
import DataTable from '../components/DataTable';
import { AxiosError } from 'axios';
import { Link } from 'react-router-dom';
import { CronjobEnabledSwitch } from '../components/CronjobEnabledSwitch';
import { fetchCronjobs } from '../api';
import { CronPopup, QueryProgress } from '../components/QueryProgress';
import LinkWithState from '../components/LinkWithState';

export default function Cronjobs() {
    return (
        <DefaultLayout>
            <Head>
                <title>Cronjobs</title>
            </Head>

            <Hero>
                <Hero.Title>Cronjobs</Hero.Title>
                <Hero.Summary>
                    Cronjob is a scheduled task that sends a request to an URL.
                    <br />
                    Go to a project to create a new cronjob.
                </Hero.Summary>
            </Hero>

            <CronjobList />
        </DefaultLayout>
    );
}

const CronjobList: React.FC = () => {
    const query = useQuery<CronjobListDto[], AxiosError>('cronjobs', fetchCronjobs);
    const translateError = useTranslateApiError();

    const columns = React.useMemo(
        () =>
            [
                {
                    Header: 'Title',
                    accessor: 'title',
                    Cell: ({ row, value }) => (
                        <LinkWithState
                            emphasize
                            pathname={`/cronjobs/${(row as any).original.id}`}
                            state={{ ...row.original }}
                        >
                            {value}
                        </LinkWithState>
                    ),
                },
                {
                    Header: 'Project',
                    accessor: 'projectTitle',
                    Cell: ({ row, value }) => (
                        <LinkWithState
                            pathname={`/projects/${(row as any).original.projectId}`}
                            state={{ title: value }}
                        >
                            {value}
                        </LinkWithState>
                    ),
                },
                {
                    Header: 'Schedule',
                    accessor: 'cron',
                    Cell: ({ value }) => (
                        <CronPopup cron={value} placement="right">
                            <code>{value}</code>
                        </CronPopup>
                    ),
                },
                {
                    Header: 'URL',
                    accessor: 'url',
                    Cell: ({ value }) => <code>{value}</code>,
                },
                { Header: 'Method', accessor: 'httpMethod' },
                {
                    Header: 'Enabled',
                    accessor: 'enabled',
                    Cell: ({ value, row }) => (
                        <CronjobEnabledSwitch enabled={value} id={row.original.id} projectId={row.original.projectId} />
                    ),
                },
            ] as Column<CronjobListDto>[],
        []
    );

    return (
        <Clamp>
            {query.error && translateError(query.error, 'list cronjobs')}
            <QueryProgress query={query} />
            {!query.isPlaceholderData && query.data && <DataTable columns={columns} data={query.data} />}
        </Clamp>
    );
};
